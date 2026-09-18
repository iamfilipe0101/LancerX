using LancerX.Models;
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
    public FrmPrincipal()
    {
        InitializeComponent();

        // pega o nome e cargo da sessão (não mais de parâmetro)
        lblUsuarioLogado.Text = "Logado como: " + SessaoAtual.NomeCompleto + " (" + SessaoAtual.Cargo + ")";

        // se não é Admin, esconde o menu de administrador
        if (SessaoAtual.Cargo != "Admin")
        {
            administradorToolStripMenuItem.Enabled = false;
        }
    }
    //Botao de abrir Cadastro de clientes

    private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        FrmClientesCadastrados tela = new FrmClientesCadastrados();
        tela.MdiParent = this;
        tela.Show();
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
        FrmUsuariosCadastrados tela = new FrmUsuariosCadastrados();
        //o pai ( menu principal ) é o principal 
        tela.MdiParent = this;
        tela.Show(); //Abrindo dentro não ShowDialog
    }

    private void cadastroDeVeiculosToolStripMenuItem_Click(object sender, EventArgs e)
    {
        FrmVeiculosCadastrados tela = new FrmVeiculosCadastrados();
        tela.MdiParent = this;
        tela.Show();
    }
}