namespace LancerX
{
    partial class FrmEditarUsuario
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
            btnCancelar = new Button();
            btnSalvar = new Button();
            cboCargo = new ComboBox();
            txtSenha = new TextBox();
            txtLogin = new TextBox();
            txtNome = new TextBox();
            lblCargo = new Label();
            lblPassword = new Label();
            lblLogin = new Label();
            lblNomeCompleto = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(427, 243);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Voltar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(282, 154);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(127, 60);
            btnSalvar.TabIndex = 18;
            btnSalvar.Text = "Salvar!";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // cboCargo
            // 
            cboCargo.FormattingEnabled = true;
            cboCargo.Items.AddRange(new object[] { "Atendente", "Admin" });
            cboCargo.Location = new Point(288, 61);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(121, 23);
            cboCargo.TabIndex = 17;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(29, 191);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(158, 23);
            txtSenha.TabIndex = 16;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(29, 136);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(158, 23);
            txtLogin.TabIndex = 15;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(29, 65);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(158, 23);
            txtNome.TabIndex = 14;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(289, 37);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(39, 15);
            lblCargo.TabIndex = 13;
            lblCargo.Text = "Cargo";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(29, 162);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 12;
            lblPassword.Text = "Password";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(29, 100);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(37, 15);
            lblLogin.TabIndex = 11;
            lblLogin.Text = "Login";
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Location = new Point(29, 37);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(96, 15);
            lblNomeCompleto.TabIndex = 10;
            lblNomeCompleto.Text = "Nome Completo";
            // 
            // FrmEditarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 312);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(cboCargo);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(txtNome);
            Controls.Add(lblCargo);
            Controls.Add(lblPassword);
            Controls.Add(lblLogin);
            Controls.Add(lblNomeCompleto);
            Name = "FrmEditarUsuario";
            Text = "Editar Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnSalvar;
        private ComboBox cboCargo;
        private TextBox txtSenha;
        private TextBox txtLogin;
        private TextBox txtNome;
        private Label lblCargo;
        private Label lblPassword;
        private Label lblLogin;
        private Label lblNomeCompleto;
    }
}