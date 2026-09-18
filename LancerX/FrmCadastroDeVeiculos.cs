using ControleDeEstoque;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LancerX
{
    public partial class FrmCadastroDeVeiculos : Form
    {
        private void Aviso(string aviso)
        {
            FrmAviso msg = new FrmAviso(aviso);
            msg.ShowDialog(this);
        }
        //Funcao de verificar campo vazio
        private bool CampoVazio(string valor, string nomeCampo)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                Aviso("O campo " + nomeCampo + " está vazio!");
                return true;// " Sim está vazio "
            }
            return false; // não está vazio
        }
        public FrmCadastroDeVeiculos()
        {
            InitializeComponent();
           
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // 1. valida campos vazios
            if (CampoVazio(txtPlaca.Text, "Placa")) return;
            if (CampoVazio(txtValorDiaria.Text, "Valor diária")) return;

            // 2. converte o ValorDiaria (TextBox, digitado -> TryParse)
            if (!double.TryParse(txtValorDiaria.Text, out double valorDiaria))
            {
                Aviso("Valor diária inválido!");
                return;
            }

            // 3. converte o Ano (ComboBox, opção fixa -> Parse direto)
            int ano = int.Parse(cboAno.Text);

            // 4. monta e executa o INSERT (repara o ESPAÇO antes de VALUES)
            string sql = "INSERT INTO Carros (Placa, Modelo, Ano, Cor, ValorDiaria, Disponivel) " +
                         "VALUES (@placa, @modelo, @ano, @cor, @valorDiaria, @disponivel)";

            using (SqlConnection conexao = new SqlConnection(ConexaoBD.stringConexao))
            {
                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@placa", txtPlaca.Text);
                comando.Parameters.AddWithValue("@modelo", cboModelo.Text);
                comando.Parameters.AddWithValue("@ano", ano);              // a variável convertida
                comando.Parameters.AddWithValue("@cor", cboCor.Text);
                comando.Parameters.AddWithValue("@valorDiaria", valorDiaria);  // a variável convertida
                comando.Parameters.AddWithValue("@disponivel", 1);        // carro novo nasce disponível

                conexao.Open();
                comando.ExecuteNonQuery();   // executa o INSERT
            }

            Aviso("Carro cadastrado!");
            // limpar campos, etc.
            txtPlaca.Text = "";
            txtValorDiaria.Text = "";
            txtPlaca.Focus();
        }

        private void FrmCadastroDeVeiculos_Load(object sender, EventArgs e)
        {
            cboAno.SelectedIndex = 0;
            cboModelo.SelectedIndex = 0;
            cboCor.SelectedIndex = 0;
        }
    }
}
