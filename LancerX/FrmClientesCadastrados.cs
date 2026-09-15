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
    public partial class FrmClientesCadastrados : Form
    {
        private void Aviso(string aviso)
        {
            FrmAviso msg = new FrmAviso(aviso);
            msg.ShowDialog(this);
        }
        private void CarregarGrid()
        {
            //string que faz a busca no banco
            string sql = "SELECT Id, Nome, Cpf, Cnh, Telefone, Email, Endereco FROM Clientes";



            using (SqlConnection conexao = new SqlConnection(ConexaoBD.stringConexao))
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, conexao);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);          // enche a tabela com o resultado do SELECT
                dgvClientes.DataSource = tabela;  // joga no grid
            }
            dgvClientes.ReadOnly = true;
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToOrderColumns = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // ── esconder Id e a coluna cinza da setinha ──
            dgvClientes.Columns["Id"].Visible = false;
            dgvClientes.RowHeadersVisible = false;

            // ── colunas preenchem a largura toda ──
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // ── tamanhos (peso) de cada coluna ──
            dgvClientes.Columns["Nome"].FillWeight = 150;      // grande
            dgvClientes.Columns["Email"].FillWeight = 150;     // grande
            dgvClientes.Columns["Endereco"].FillWeight = 180;  // maior
            dgvClientes.Columns["Cpf"].FillWeight = 80;        // menor
            dgvClientes.Columns["Cnh"].FillWeight = 80;        // menor
            dgvClientes.Columns["Telefone"].FillWeight = 90;   // menor
        }
        public FrmClientesCadastrados()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            FrmCadastroClientes tela = new FrmCadastroClientes();
            tela.ShowDialog(this);
            CarregarGrid();
        }
      

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // tem linha selecionada?
            if (dgvClientes.CurrentRow == null)
            {
                Aviso("Selecione um usuário!");
                return;
            }

            // pega o Id da linha selecionada
            int id = Convert.ToInt32(dgvClientes.CurrentRow.Cells["Id"].Value);

            // abre o form de edição passando o Id
            FrmEditarClientes tela = new FrmEditarClientes(id);
            tela.ShowDialog(this);

            // quando fecha, atualiza o grid
            CarregarGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                Aviso("Selecione um usuário!");
                return;
            }

            int id = Convert.ToInt32(dgvClientes.CurrentRow.Cells["Id"].Value);

            DialogResult resposta = MessageBox.Show(
                "Deseja realmente excluir este Cliente?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta != DialogResult.Yes)   // se NÃO clicou Sim, sai
                return;
            string sql = "DELETE FROM Clientes WHERE Id = @id";
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmClientesCadastrados_Load_1(object sender, EventArgs e)
        {
            CarregarGrid();

        }
    }
}
