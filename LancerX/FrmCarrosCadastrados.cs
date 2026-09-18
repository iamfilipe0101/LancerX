using ControleDeEstoque;
using LancerX.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LancerX
{
    public partial class FrmUsuariosCadastrados : Form
    {
        private void Aviso(string aviso)
        {
            FrmAviso msg = new FrmAviso(aviso);
            msg.ShowDialog(this);
        }
        private void CarregarGrid()
        {
            //string que faz a busca no banco
            string sql = "SELECT Id, Login, NomeCompleto, Cargo FROM Usuarios";



            using (SqlConnection conexao = new SqlConnection(ConexaoBD.stringConexao))
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, conexao);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);          // enche a tabela com o resultado do SELECT
                dgvUsuarios.DataSource = tabela;  // joga no grid
            }
            dgvUsuarios.ReadOnly = true;                    // não edita célula
            dgvUsuarios.AllowUserToAddRows = false;         // some o asterisco (*)
            dgvUsuarios.AllowUserToDeleteRows = false;      // não deleta pelo Delete do teclado
            dgvUsuarios.AllowUserToOrderColumns = false;    // não arrasta colunas
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;  // seleciona linha toda
        }

        public FrmUsuariosCadastrados()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            FrmCadastroUsuario tela = new FrmCadastroUsuario();
            //o pai ( menu principal ) é o principal 
            tela.ShowDialog(this); //Abrindo dentro não ShowDialog
            CarregarGrid();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUsuariosCadastrados_Load(object sender, EventArgs e)
        {
            CarregarGrid();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // 1. tem linha selecionada?
            if (dgvUsuarios.CurrentRow == null)
            {
                Aviso("Selecione um usuário!");
                return;
            }

            // 2. pega o Id da linha selecionada (ANTES de tudo, pra poder validar)
            int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["Id"].Value);

            // 3. não pode excluir a si mesmo
            if (id == SessaoAtual.UsuarioId)
            {
                Aviso("Você não pode excluir o próprio usuário logado!");
                return;
            }

            // 4. confirmação
            DialogResult resposta = MessageBox.Show(
                "Deseja realmente excluir este usuário?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta != DialogResult.Yes)   // se NÃO clicou Sim, sai
                return;

            // 5. só chega aqui se confirmou -> executa o DELETE
            string sql = "DELETE FROM Usuarios WHERE Id = @id";
            using (SqlConnection conexao = new SqlConnection(ConexaoBD.stringConexao))
            {
                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@id", id);
                conexao.Open();
                comando.ExecuteNonQuery();
            }

            // 6. atualiza e avisa
            CarregarGrid();
            Aviso("Usuário excluído!");
        }

        
            private void btnEditar_Click(object sender, EventArgs e)
        {
            // tem linha selecionada?
            if (dgvUsuarios.CurrentRow == null)
            {
                Aviso("Selecione um usuário!");
                return;
            }

            // pega o Id da linha selecionada
            int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["Id"].Value);

            // abre o form de edição passando o Id
            FrmEditarUsuario tela = new FrmEditarUsuario(id);
            tela.ShowDialog(this);

            // quando fecha, atualiza o grid
            CarregarGrid();
        }
    
    }
}
