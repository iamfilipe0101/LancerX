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
    public partial class FrmCadastroUsuario : Form
    {   

        //Funcao Aviso
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
        public FrmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (CampoVazio(txtLogin.Text, "Login")) return;
            if (CampoVazio(txtNomeCompleto.Text, "Nome Completo")) return;
            if (CampoVazio(txtPassword.Text, "Senha")) return;
            if (CampoVazio(cmbCargo.Text, "Cargo")) return;

            string sql = "INSERT INTO Usuarios (Login, Senha, NomeCompleto, Cargo) " +
                 "VALUES (@login, @senha, @nome, @cargo)";

            using (SqlConnection conexao = new SqlConnection(ConexaoBD.stringConexao))
            {
                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@login", txtLogin.Text);
                comando.Parameters.AddWithValue("@senha", txtPassword.Text);
                comando.Parameters.AddWithValue("@nome", txtNomeCompleto.Text);
                comando.Parameters.AddWithValue("@cargo", cmbCargo.Text);

                conexao.Open();
                comando.ExecuteNonQuery();   // executa o INSERT
            }

            txtLogin.Text = "";
            txtNomeCompleto.Text = "";
            txtPassword.Text = "";
            cmbCargo.Text = "";
            Aviso("Usuário Cadastrado!");
            txtNomeCompleto.Focus();
        }
    }
}
