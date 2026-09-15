namespace LancerX
{
    partial class FrmCadastroClientes
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
            txtNome = new TextBox();
            txtCpf = new TextBox();
            txtCnh = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            txtEndereco = new TextBox();
            lblNome = new Label();
            lblCpf = new Label();
            lblCnh = new Label();
            lblTelefone = new Label();
            lblEmail = new Label();
            lblEndereco = new Label();
            btnSalvar = new Button();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(25, 83);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(205, 23);
            txtNome.TabIndex = 0;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(25, 172);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(100, 23);
            txtCpf.TabIndex = 1;
            // 
            // txtCnh
            // 
            txtCnh.Location = new Point(25, 255);
            txtCnh.Name = "txtCnh";
            txtCnh.Size = new Size(100, 23);
            txtCnh.TabIndex = 2;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(303, 83);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(303, 172);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(216, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(303, 255);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(316, 23);
            txtEndereco.TabIndex = 5;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(25, 46);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(96, 15);
            lblNome.TabIndex = 6;
            lblNome.Text = "Nome Completo";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(25, 141);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(28, 15);
            lblCpf.TabIndex = 7;
            lblCpf.Text = "CPF";
            // 
            // lblCnh
            // 
            lblCnh.AutoSize = true;
            lblCnh.Location = new Point(25, 228);
            lblCnh.Name = "lblCnh";
            lblCnh.Size = new Size(33, 15);
            lblCnh.TabIndex = 8;
            lblCnh.Text = "CNH";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(303, 46);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(52, 15);
            lblTelefone.TabIndex = 9;
            lblTelefone.Text = "Telefone";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(303, 141);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(303, 228);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(56, 15);
            lblEndereco.TabIndex = 11;
            lblEndereco.Text = "Endereco";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(543, 57);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(107, 49);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar !";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(575, 314);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 13;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FrmCadastroClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 349);
            ControlBox = false;
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
            Name = "FrmCadastroClientes";
            Text = "Cadastro de clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtCpf;
        private TextBox txtCnh;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private TextBox txtEndereco;
        private Label lblNome;
        private Label lblCpf;
        private Label lblCnh;
        private Label lblTelefone;
        private Label lblEmail;
        private Label lblEndereco;
        private Button btnSalvar;
        private Button btnVoltar;
    }
}