namespace LancerX
{
    partial class FrmEditarClientes
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
            lblEndereco = new Label();
            lblEmail = new Label();
            lblTelefone = new Label();
            lblCnh = new Label();
            lblCpf = new Label();
            lblNome = new Label();
            txtEndereco = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            txtCnh = new TextBox();
            txtCpf = new TextBox();
            txtNome = new TextBox();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(576, 308);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 27;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(544, 51);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(107, 49);
            btnSalvar.TabIndex = 26;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(304, 222);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(56, 15);
            lblEndereco.TabIndex = 25;
            lblEndereco.Text = "Endereco";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(304, 135);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 24;
            lblEmail.Text = "Email";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(304, 40);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(52, 15);
            lblTelefone.TabIndex = 23;
            lblTelefone.Text = "Telefone";
            // 
            // lblCnh
            // 
            lblCnh.AutoSize = true;
            lblCnh.Location = new Point(26, 222);
            lblCnh.Name = "lblCnh";
            lblCnh.Size = new Size(33, 15);
            lblCnh.TabIndex = 22;
            lblCnh.Text = "CNH";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(26, 135);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(28, 15);
            lblCpf.TabIndex = 21;
            lblCpf.Text = "CPF";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(26, 40);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(96, 15);
            lblNome.TabIndex = 20;
            lblNome.Text = "Nome Completo";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(304, 249);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.RightToLeft = RightToLeft.No;
            txtEndereco.Size = new Size(316, 23);
            txtEndereco.TabIndex = 19;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(304, 166);
            txtEmail.Name = "txtEmail";
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.Size = new Size(216, 23);
            txtEmail.TabIndex = 18;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(304, 77);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.RightToLeft = RightToLeft.No;
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 17;
            // 
            // txtCnh
            // 
            txtCnh.Location = new Point(26, 249);
            txtCnh.Name = "txtCnh";
            txtCnh.RightToLeft = RightToLeft.No;
            txtCnh.Size = new Size(100, 23);
            txtCnh.TabIndex = 16;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(26, 166);
            txtCpf.Name = "txtCpf";
            txtCpf.RightToLeft = RightToLeft.No;
            txtCpf.Size = new Size(100, 23);
            txtCpf.TabIndex = 15;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(26, 77);
            txtNome.Name = "txtNome";
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.Size = new Size(205, 23);
            txtNome.TabIndex = 14;
            // 
            // FrmEditarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 363);
            Controls.Add(btnVoltar);
            Controls.Add(btnSalvar);
            Controls.Add(lblEndereco);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefone);
            Controls.Add(lblCnh);
            Controls.Add(lblCpf);
            Controls.Add(lblNome);
            Controls.Add(txtEndereco);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(txtCnh);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Name = "FrmEditarClientes";
            RightToLeft = RightToLeft.Yes;
            Text = "Edicao de Clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private Button btnSalvar;
        private Label lblEndereco;
        private Label lblEmail;
        private Label lblTelefone;
        private Label lblCnh;
        private Label lblCpf;
        private Label lblNome;
        private TextBox txtEndereco;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private TextBox txtCnh;
        private TextBox txtCpf;
        private TextBox txtNome;
    }
}