using ControleDeEstoque;
using LancerX.Models;
using Microsoft.Data.SqlClient;
using System.Numerics;
using static LancerX.FrmPrincipal;
namespace LancerX
{
    public partial class FrmLogin : Form
    {
        List<Usuario> usuarios = new List<Usuario>();

        // atalho pra não ficar criando o FrmAviso na mão toda hora
        private void Aviso(string aviso)
        {
            FrmAviso msg = new FrmAviso(aviso);
            msg.ShowDialog(this);
        }

        public FrmLogin()
        {
            InitializeComponent();
        }

       private void btnLogin_Click(object sender, EventArgs e)
        {
            // pergunta pro banco se existe alguém com esse login E essa senha
            string sql = "SELECT * FROM Usuarios WHERE Login = @login AND Senha = @senha";

            using (SqlConnection conexao = new SqlConnection(ConexaoBD.stringConexao))
            {
                SqlCommand comando = new SqlCommand(sql, conexao);

                // preenche os espaços do SQL com o que o cara digitou (protege contra invasão)
                comando.Parameters.AddWithValue("@login", txtUsuario.Text);
                comando.Parameters.AddWithValue("@senha", txtSenha.Text);

                conexao.Open();
                SqlDataReader leitor = comando.ExecuteReader();

                // se o Read() achou uma linha, o usuário existe -> login válido
                if (leitor.Read())
                {
                    // guarda quem logou na sessão, pra qualquer tela poder consultar depois
                    SessaoAtual.UsuarioId = Convert.ToInt32(leitor["Id"]);
                    SessaoAtual.Login = leitor["Login"].ToString();
                    SessaoAtual.NomeCompleto = leitor["NomeCompleto"].ToString();
                    SessaoAtual.Cargo = leitor["Cargo"].ToString();

                    FrmPrincipal principal = new FrmPrincipal();
                    principal.Show();
                    this.Hide();   // esconde o login em vez de fechar (senão o programa cairia junto)
                }
                else
                {
                    // não achou ninguém = login ou senha errados
                    Aviso("Usuário ou senha inválidos!");
                }
            }
        }
        //Clicou no botao cancelar também fechar a aplicacao
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        //Evento para quando fechar o Frm de login fechar a aplicacao
        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}