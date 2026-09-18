using ControleDeEstoque;
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
    public partial class FrmEditarVeiculo : Form
    {
        
        int idVeiculo;   // guarda qual usuário tá editando
        private void Aviso(string aviso)
        {
            FrmAviso msg = new FrmAviso(aviso);
            msg.ShowDialog(this);
        }
        private bool CampoVazio(string valor, string nomeCampo)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                Aviso("O campo " + nomeCampo + " está vazio!");
                return true;// " Sim está vazio "
            }
            return false; // não está vazio
        }
        public FrmEditarVeiculo(int id)
        {
            InitializeComponent();
            idVeiculo = id;
            string sql = "SELECT * FROM Carros WHERE Id = @id";
            using (SqlConnection conexao = new SqlConnection(ConexaoBD.stringConexao))
            {
                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@id", id);
                conexao.Open();
                SqlDataReader leitor = comando.ExecuteReader();
                if (leitor.Read())
                {
                    txtPlaca.Text = leitor["Placa"].ToString();
                    cboModelo.Text = leitor["Modelo"].ToString();
                    cboAno.Text = leitor["Ano"].ToString();
                    cboCor.Text = leitor["Cor"].ToString();
                    txtValorDiaria.Text = leitor["ValorDiaria"].ToString();
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (CampoVazio(txtPlaca.Text, "Placa")) return;
            if (CampoVazio(txtValorDiaria.Text, "Valor diária")) return;
            if (!double.TryParse(txtValorDiaria.Text, out double valorDiaria))
            {
                Aviso("Valor diária inválido!");
                return;
            }

            string sql = "UPDATE Carros SET Placa = @placa, Modelo = @modelo, Ano = @ano, Cor = @cor, ValorDiaria = @valordiaria WHERE Id = @id";

            using (SqlConnection conexao = new SqlConnection(ConexaoBD.stringConexao))
            {
                SqlCommand comando = new SqlCommand( sql, conexao);
                comando.Parameters.AddWithValue("@placa", txtPlaca.Text);
                comando.Parameters.AddWithValue("@modelo", cboModelo.Text);
                comando.Parameters.AddWithValue("@ano", cboAno.Text);
                comando.Parameters.AddWithValue("@cor", cboCor.Text);
                comando.Parameters.AddWithValue("@valordiaria", valorDiaria);
                comando.Parameters.AddWithValue("@id", idVeiculo);
                conexao.Open();
                comando.ExecuteNonQuery();
            }
            Aviso("Veiculo atualizado!");
            this.Close();
        }
    }
}
