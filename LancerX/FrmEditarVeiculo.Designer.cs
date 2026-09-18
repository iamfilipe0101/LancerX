namespace LancerX
{
    partial class FrmEditarVeiculo
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
            btnVoltar = new Button();
            btnSalvar = new Button();
            txtValorDiaria = new TextBox();
            lblValorDiaria = new Label();
            txtCor = new Label();
            cboCor = new ComboBox();
            cboAno = new ComboBox();
            cboModelo = new ComboBox();
            lblAno = new Label();
            lblModelo = new Label();
            lblPlaca = new Label();
            txtPlaca = new TextBox();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(705, 377);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 25;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(648, 254);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(118, 51);
            btnSalvar.TabIndex = 24;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtValorDiaria
            // 
            txtValorDiaria.Location = new Point(460, 180);
            txtValorDiaria.MaxLength = 5;
            txtValorDiaria.Name = "txtValorDiaria";
            txtValorDiaria.Size = new Size(100, 23);
            txtValorDiaria.TabIndex = 23;
            // 
            // lblValorDiaria
            // 
            lblValorDiaria.AutoSize = true;
            lblValorDiaria.Location = new Point(460, 150);
            lblValorDiaria.Name = "lblValorDiaria";
            lblValorDiaria.Size = new Size(81, 15);
            lblValorDiaria.TabIndex = 22;
            lblValorDiaria.Text = "Valor da diária";
            // 
            // txtCor
            // 
            txtCor.AutoSize = true;
            txtCor.Location = new Point(460, 50);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(26, 15);
            txtCor.TabIndex = 21;
            txtCor.Text = "Cor";
            // 
            // cboCor
            // 
            cboCor.FormattingEnabled = true;
            cboCor.Items.AddRange(new object[] { "Preto", "Branco", "Prata", "Cinza", "Vermelho", "Azul" });
            cboCor.Location = new Point(460, 77);
            cboCor.Name = "cboCor";
            cboCor.Size = new Size(121, 23);
            cboCor.TabIndex = 20;
            // 
            // cboAno
            // 
            cboAno.FormattingEnabled = true;
            cboAno.Items.AddRange(new object[] { "2011", "2012", "2013", "2014", "2015", "2016", "2017" });
            cboAno.Location = new Point(21, 254);
            cboAno.Name = "cboAno";
            cboAno.Size = new Size(121, 23);
            cboAno.TabIndex = 19;
            // 
            // cboModelo
            // 
            cboModelo.FormattingEnabled = true;
            cboModelo.Items.AddRange(new object[] { "Lancer GT", "Lancer GLX", "Lancer HL", "Lancer HL-T", "Lancer GLS", "Lancer Evolution I", "Lancer Evolution II", "Lancer Evolution III", "Lancer Evolution IV", "Lancer Evolution V", "Lancer Evolution VI", "Lancer Evolution VII", "Lancer Evolution VIII", "Lancer Evolution IX", "Lancer Evolution X" });
            cboModelo.Location = new Point(21, 164);
            cboModelo.Name = "cboModelo";
            cboModelo.Size = new Size(302, 23);
            cboModelo.TabIndex = 18;
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Location = new Point(21, 218);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(29, 15);
            lblAno.TabIndex = 17;
            lblAno.Text = "Ano";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(21, 132);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(48, 15);
            lblModelo.TabIndex = 16;
            lblModelo.Text = "Modelo";
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Location = new Point(20, 50);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(35, 15);
            lblPlaca.TabIndex = 15;
            lblPlaca.Text = "Placa";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(20, 77);
            txtPlaca.MaxLength = 7;
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(303, 23);
            txtPlaca.TabIndex = 14;
            // 
            // FrmEditarVeiculo
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
            Name = "FrmEditarVeiculo";
            Text = "Editar Veiculo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private Button btnSalvar;
        private TextBox txtValorDiaria;
        private Label lblValorDiaria;
        private Label txtCor;
        private ComboBox cboCor;
        private ComboBox cboAno;
        private ComboBox cboModelo;
        private Label lblAno;
        private Label lblModelo;
        private Label lblPlaca;
        private TextBox txtPlaca;
    }
}