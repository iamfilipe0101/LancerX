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
    public partial class FrmEditarUsuario : Form
    {
        int idUsuario;   // guarda qual usuário tá editando
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

        public FrmEditarUsuario(int id)
        {
            InitializeComponent();
            idUsuario = id;   // guarda o Id pra usar no UPDATE depois

            // busca os dados atuais do usuário e preenche os campos
            string sql = "SELECT * FROM Usuarios WHERE Id = @id";
            using (SqlConnection conexao = new SqlConnection(ConexaoBD.stringConexao))
            {
                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@id", id);
                conexao.Open();
                SqlDataReader leitor = comando.ExecuteReader();
                if (leitor.Read())
                {
                    txtLogin.Text = leitor["Login"].ToString();
                    txtNome.Text = leitor["NomeCompleto"].ToString();
                    txtSenha.Text = leitor["Senha"].ToString();
                    cboCargo.Text = leitor["Cargo"].ToString();
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (CampoVazio(txtLogin.Text, "Login")) return;
            if (CampoVazio(txtNome.Text, "Nome Completo")) return;
            if (CampoVazio(txtSenha.Text, "Senha")) return;
            if (CampoVazio(cboCargo.Text, "Cargo")) return;

            string sql = "UPDATE Usuarios SET Login = @login, Senha = @senha, " + "NomeCompleto = @nome, Cargo = @cargo WHERE Id = @id";

            using (SqlConnection conexao = new SqlConnection(ConexaoBD.stringConexao))
            {
                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@login", txtLogin.Text);
                comando.Parameters.AddWithValue("@senha", txtSenha.Text);
                comando.Parameters.AddWithValue("@nome", txtNome.Text);
                comando.Parameters.AddWithValue("@cargo", cboCargo.Text);
                comando.Parameters.AddWithValue("@id", idUsuario);   // QUAL usuário atualizar

                conexao.Open();
                comando.ExecuteNonQuery();
            }

            Aviso("Usuário atualizado!");
            this.Close();
        }
    }
}
