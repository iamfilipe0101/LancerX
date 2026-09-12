using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControleDeEstoque
{
    public partial class FrmAviso : Form
    {
        string? msg;
        public FrmAviso(string msg)
        {
            InitializeComponent();
            lblAviso.Text = msg;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
