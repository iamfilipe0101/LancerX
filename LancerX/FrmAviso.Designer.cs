namespace ControleDeEstoque
{
    partial class FrmAviso
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
            btnOK = new Button();
            lblAviso = new Label();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(73, 65);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK !";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // lblAviso
            // 
            lblAviso.AutoSize = true;
            lblAviso.Location = new Point(32, 30);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(36, 15);
            lblAviso.TabIndex = 1;
            lblAviso.Text = "Aviso";
            lblAviso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmAviso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(214, 116);
            ControlBox = false;
            Controls.Add(lblAviso);
            Controls.Add(btnOK);
            Name = "FrmAviso";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Aviso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOK;
        private Label lblAviso;
    }
}