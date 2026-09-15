using ControleDeEstoque;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace LancerX
{
    public partial class FrmEditarClientes : Form
    {
    int idUsuario;
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
        public FrmEditarClientes(int id)
        {
            InitializeComponent();
            idUsuario = id;

            string sql = "SELECT * FROM Clientes WHERE Id = @id";
            using (SqlConnection conexao = new SqlConnection(ConexaoBD.stringConexao))
            {
                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@id", id);
                conexao.Open();
                SqlDataReader leitor = comando.ExecuteReader();
                if (leitor.Read())
                {
                    txtNome.Text = leitor["Nome"].ToString();
                    txtCpf.Text = leitor["Cpf"].ToString();
                    txtCnh.Text = leitor["Cnh"].ToString();
                    txtTelefone.Text = leitor["Telefone"].ToString();
                    txtEndereco.Text = leitor["Endereco"].ToString();
                    txtEmail.Text = leitor["Email"].ToString();
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (CampoVazio(txtNome.Text, "Nome")) return;
            if (CampoVazio(txtCpf.Text, "Cpf")) return;
            if (CampoVazio(txtCnh.Text, "Cnh")) return;
            if (CampoVazio(txtTelefone.Text, "Telefone")) return;
            if (CampoVazio(txtEmail.Text, "Email")) return;
            if (CampoVazio(txtEndereco.Text, "Endereço")) return;

            string sql = "UPDATE Clientes SET Nome = @nome, Cpf = @cpf, Cnh = @cnh, Telefone = @Telefone, Email = @email, Endereco = @Endereco WHERE Id = @id";
            using (SqlConnection conexao = new SqlConnection(ConexaoBD.stringConexao))
            {
                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@nome", txtNome.Text);
                comando.Parameters.AddWithValue("@cpf", txtCpf.Text);
                comando.Parameters.AddWithValue("@cnh", txtCnh.Text);
                comando.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                comando.Parameters.AddWithValue("@email", txtEmail.Text);
                comando.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                comando.Parameters.AddWithValue("@id", idUsuario);
                conexao.Open();
                comando.ExecuteNonQuery();

            }
            Aviso("Usuário atualizado!");
            this.Close();
        }
    }
}
