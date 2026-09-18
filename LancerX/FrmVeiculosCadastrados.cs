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
    public partial class FrmVeiculosCadastrados : Form
    {
        private void Aviso(string aviso)
        {
            FrmAviso msg = new FrmAviso(aviso);
            msg.ShowDialog(this);
        }
        private void CarregarGrid()
        {
            //string que faz a busca no banco
            string sql = "SELECT Id, Placa, Modelo, Ano, Cor, ValorDiaria, Disponivel FROM Carros";



            using (SqlConnection conexao = new SqlConnection(ConexaoBD.stringConexao))
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, conexao);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);          // enche a tabela com o resultado do SELECT
                dgvVeiculos.DataSource = tabela;  // joga no grid
            }
            dgvVeiculos.ReadOnly = true;                    // não edita célula
            dgvVeiculos.AllowUserToAddRows = false;         // some o asterisco (*)
            dgvVeiculos.AllowUserToDeleteRows = false;      // não deleta pelo Delete do teclado
            dgvVeiculos.AllowUserToOrderColumns = false;    // não arrasta colunas
            dgvVeiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;  // seleciona linha toda
        }
        public FrmVeiculosCadastrados()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            FrmCadastroDeVeiculos tela = new FrmCadastroDeVeiculos();
            //o pai ( menu principal ) é o principal 
            tela.ShowDialog(this); //Abrindo dentro não ShowDialog
            CarregarGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            {
                // tem linha selecionada?
                if (dgvVeiculos.CurrentRow == null)
                {
                    Aviso("Selecione um veiculo!");
                    return;
                }

                // pega o Id da linha selecionada
                int id = Convert.ToInt32(dgvVeiculos.CurrentRow.Cells["Id"].Value);

                // abre o form de edição passando o Id
                FrmEditarVeiculo tela = new FrmEditarVeiculo(id);
                tela.ShowDialog(this);

                // quando fecha, atualiza o grid
                CarregarGrid();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // 1. tem linha selecionada?
            if (dgvVeiculos.CurrentRow == null)
            {
                Aviso("Selecione um veiculo!");
                return;
            }

            // 2. pega o Id da linha selecionada (ANTES de tudo, pra poder validar)
            bool disponibilidade = Convert.ToBoolean(dgvVeiculos.CurrentRow.Cells["Disponivel"].Value);

            int id = Convert.ToInt32(dgvVeiculos.CurrentRow.Cells["Id"].Value);

            // 3. não pode excluir o carro alugado
            if (!disponibilidade)
            {
                Aviso("Você não pode excluir um veiculo que está em locação");
                return;
            }

            // 4. confirmação
            DialogResult resposta = MessageBox.Show(
                "Deseja realmente excluir este veiculo?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta != DialogResult.Yes)   // se NÃO clicou Sim, sai
                return;

            // 5. só chega aqui se confirmou -> executa o DELETE
            string sql = "DELETE FROM Carros WHERE Id = @id";
            using (SqlConnection conexao = new SqlConnection(ConexaoBD.stringConexao))
            {
                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@id", id);
                conexao.Open();
                comando.ExecuteNonQuery();
            }

            // 6. atualiza e avisa
            CarregarGrid();
            Aviso("Veiculo excluído!");
        }
        

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVeiculosCadastrados_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
