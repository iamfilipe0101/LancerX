using ControleDeEstoque;
using LancerX.Models;
using Microsoft.Data.SqlClient;
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
            // (@login e @senha ficam vazios de propósito, preencho eles logo abaixo)
            string sql = "SELECT * FROM Usuarios WHERE Login = @login AND Senha = @senha";

            using (SqlConnection conexao = new SqlConnection(ConexaoBD.stringConexao))
            {
                SqlCommand comando = new SqlCommand(sql, conexao);

                // aqui preencho os espaços do SQL com o que o cara digitou
                // fazer assim (e não colar o texto direto) evita que alguém quebre o banco escrevendo comando no campo
                comando.Parameters.AddWithValue("@login", txtUsuario.Text);
                comando.Parameters.AddWithValue("@senha", txtSenha.Text);

                conexao.Open();
                SqlDataReader leitor = comando.ExecuteReader();

                // se o Read() achou uma linha, é porque o usuário existe -> login válido
                if (leitor.Read())
                {
                    // aproveito e pego o nome e o cargo pra mandar pra tela principal mostrar
                    string nome = leitor["NomeCompleto"].ToString();
                    string cargo = leitor["Cargo"].ToString();

                    //Abrir o frmPrincipal passando nome e cargo
                    FrmPrincipal principal = new FrmPrincipal(nome, cargo);
                    principal.Show();
                    this.Hide();   // escondo o login em vez de fechar (senão o programa cairia junto)
                }
                else
                {
                    // não achou ninguém = ou o login tá errado, ou a senha
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