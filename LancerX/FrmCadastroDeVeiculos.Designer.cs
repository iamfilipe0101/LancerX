namespace LancerX
{
    partial class FrmCadastroDeVeiculos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPlaca = new TextBox();
            lblPlaca = new Label();
            lblModelo = new Label();
            lblAno = new Label();
            cboModelo = new ComboBox();
            cboAno = new ComboBox();
            cboCor = new ComboBox();
            txtCor = new Label();
            lblValorDiaria = new Label();
            txtValorDiaria = new TextBox();
            btnSalvar = new Button();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(28, 115);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(303, 23);
            txtPlaca.TabIndex = 0;
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Location = new Point(28, 88);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(35, 15);
            lblPlaca.TabIndex = 1;
            lblPlaca.Text = "Placa";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(29, 170);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(48, 15);
            lblModelo.TabIndex = 2;
            lblModelo.Text = "Modelo";
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Location = new Point(29, 256);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(29, 15);
            lblAno.TabIndex = 4;
            lblAno.Text = "Ano";
            // 
            // cboModelo
            // 
            cboModelo.FormattingEnabled = true;
            cboModelo.Items.AddRange(new object[] { "Lancer GT", "Lancer GLX", "Lancer HL", "Lancer HL-T", "Lancer GLS", "Lancer Evolution I", "Lancer Evolution II", "Lancer Evolution III", "Lancer Evolution IV", "Lancer Evolution V", "Lancer Evolution VI", "Lancer Evolution VII", "Lancer Evolution VIII", "Lancer Evolution IX", "Lancer Evolution X" });
            cboModelo.Location = new Point(29, 202);
            cboModelo.Name = "cboModelo";
            cboModelo.Size = new Size(302, 23);
            cboModelo.TabIndex = 6;
            // 
            // cboAno
            // 
            cboAno.FormattingEnabled = true;
            cboAno.Items.AddRange(new object[] { "2011", "2012", "2013", "2014", "2015", "2016", "2017" });
            cboAno.Location = new Point(29, 292);
            cboAno.Name = "cboAno";
            cboAno.Size = new Size(121, 23);
            cboAno.TabIndex = 7;
            // 
            // cboCor
            // 
            cboCor.FormattingEnabled = true;
            cboCor.Items.AddRange(new object[] { "Preto", "Branco", "Prata", "Cinza", "Vermelho", "Azul" });
            cboCor.Location = new Point(468, 115);
            cboCor.Name = "cboCor";
            cboCor.Size = new Size(121, 23);
            cboCor.TabIndex = 8;
            // 
            // txtCor
            // 
            txtCor.AutoSize = true;
            txtCor.Location = new Point(468, 88);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(26, 15);
            txtCor.TabIndex = 9;
            txtCor.Text = "Cor";
            // 
            // lblValorDiaria
            // 
            lblValorDiaria.AutoSize = true;
            lblValorDiaria.Location = new Point(468, 188);
            lblValorDiaria.Name = "lblValorDiaria";
            lblValorDiaria.Size = new Size(81, 15);
            lblValorDiaria.TabIndex = 10;
            lblValorDiaria.Text = "Valor da diária";
            // 
            // txtValorDiaria
            // 
            txtValorDiaria.Location = new Point(468, 218);
            txtValorDiaria.Name = "txtValorDiaria";
            txtValorDiaria.Size = new Size(100, 23);
            txtValorDiaria.TabIndex = 11;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(656, 292);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(118, 51);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(713, 415);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 13;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FrmCadastroDeVeiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(btnSalvar);
            Controls.Add(txtValorDiaria);
            Controls.Add(lblValorDiaria);
            Controls.Add(txtCor);
            Controls.Add(cboCor);
            Controls.Add(cboAno);
            Controls.Add(cboModelo);
            Controls.Add(lblAno);
            Controls.Add(lblModelo);
            Controls.Add(lblPlaca);
            Controls.Add(txtPlaca);
            Name = "FrmCadastroDeVeiculos";
            Text = "Cadastros de Veiculos";
            Load += FrmCadastroDeVeiculos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPlaca;
        private Label lblPlaca;
        private Label lblModelo;
        private TextBox txtAno;
        private Label lblAno;
        private ComboBox cboModelo;
        private ComboBox cboAno;
        private ComboBox cboCor;
        private Label txtCor;
        private Label lblValorDiaria;
        private TextBox txtValorDiaria;
        private Button btnSalvar;
        private Button btnVoltar;
    }
}