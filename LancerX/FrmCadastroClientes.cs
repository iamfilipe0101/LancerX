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
    public partial class FrmCadastroClientes : Form
    {
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
        public FrmCadastroClientes()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (CampoVazio(txtNome.Text, "Nome")) return;
            if (CampoVazio(txtCpf.Text, "Cpf")) return;
            if (CampoVazio(txtCnh.Text, "Cnh")) return;
            if (CampoVazio(txtTelefone.Text, "Telefone")) return;
            if (CampoVazio(txtEmail.Text, "Email")) return;
            if (CampoVazio(txtEndereco.Text, "Endereço")) return;

            string sql = "INSERT INTO Clientes (Nome, Cpf, Cnh, Telefone, Email, Endereco)" + "VALUES (@nome, @cpf, @cnh, @telefone, @email, @endereco)";

            using (SqlConnection conexao = new SqlConnection(ConexaoBD.stringConexao))
            {
                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@nome", txtNome.Text);
                comando.Parameters.AddWithValue("@cpf", txtCpf.Text);
                comando.Parameters.AddWithValue("@cnh", txtCnh.Text);
                comando.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                comando.Parameters.AddWithValue("@email", txtEmail.Text);
                comando.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                conexao.Open();
                comando.ExecuteNonQuery();
            }
            txtNome.Text = "";
            txtCpf.Text = "";
            txtCnh.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            txtEndereco.Text = "";

            txtNome.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
