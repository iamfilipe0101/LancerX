namespace LancerX
{
    partial class FrmCadastroUsuario
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
            lblNomeCompleto = new Label();
            lblLogin = new Label();
            lblPassword = new Label();
            lblCargo = new Label();
            txtNomeCompleto = new TextBox();
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            cmbCargo = new ComboBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Location = new Point(42, 55);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(96, 15);
            lblNomeCompleto.TabIndex = 0;
            lblNomeCompleto.Text = "Nome Completo";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(42, 118);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(37, 15);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Login";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(42, 180);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(302, 55);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(39, 15);
            lblCargo.TabIndex = 3;
            lblCargo.Text = "Cargo";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(42, 83);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(158, 23);
            txtNomeCompleto.TabIndex = 4;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(42, 154);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(158, 23);
            txtLogin.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(42, 209);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(158, 23);
            txtPassword.TabIndex = 6;
            // 
            // cmbCargo
            // 
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Items.AddRange(new object[] { "Atendente", "Admin" });
            cmbCargo.Location = new Point(301, 79);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(121, 23);
            cmbCargo.TabIndex = 7;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(295, 172);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(127, 60);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar!";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(440, 261);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 296);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(cmbCargo);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(txtNomeCompleto);
            Controls.Add(lblCargo);
            Controls.Add(lblPassword);
            Controls.Add(lblLogin);
            Controls.Add(lblNomeCompleto);
            Name = "FrmCadastroUsuario";
            Text = "Cadastro de usuários";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeCompleto;
        private Label lblLogin;
        private Label lblPassword;
        private Label lblCargo;
        private TextBox txtNomeCompleto;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private ComboBox cmbCargo;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}