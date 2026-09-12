using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LancerX;

public partial class FrmPrincipal : Form
{
    bool ehLogoff = false;
    public FrmPrincipal(string nomeUsuario, string cargoUsuario)
    {
        InitializeComponent();
        // mostra numa barra ou label:
        lblUsuarioLogado.Text = "Logado como: " + nomeUsuario + " (" + cargoUsuario + ")";
        //Verifica o cargo do usuário, se não é Admin ele Esconde o menustrip de Administrador
        if (cargoUsuario != "Admin")
        {
            administradorToolStripMenuItem.Enabled = false;
        }
    }

    private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }
    //botao sair no menu strip, volta para tela de login
    private void mnuLogoff_click(object sender, EventArgs e)
    {
        ehLogoff = true;
        FrmLogin login = new FrmLogin();
        login.Show();
        this.Close();
    }
    //Evento se fechar formulario principal aplicação fecha
    private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
    {
        if (!ehLogoff)
        {
            Application.Exit();
        }
    }
    //Metodo para abrir frm de cadastro de usuario
    private void cadastrarUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
    {
        FrmCadastroUsuario tela = new FrmCadastroUsuario();
        //o pai ( menu principal ) é o principal 
        tela.MdiParent = this;
        tela.Show(); //Abrindo dentro não ShowDialog
    }
}