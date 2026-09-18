namespace LancerX
{
    partial class FrmVeiculosCadastrados
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
            btnIncluir = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            Voltar = new Button();
            dgvVeiculos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvVeiculos).BeginInit();
            SuspendLayout();
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new Point(29, 51);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(75, 23);
            btnIncluir.TabIndex = 0;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(188, 51);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(339, 51);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // Voltar
            // 
            Voltar.Location = new Point(695, 51);
            Voltar.Name = "Voltar";
            Voltar.Size = new Size(75, 23);
            Voltar.TabIndex = 3;
            Voltar.Text = "Voltar";
            Voltar.UseVisualStyleBackColor = true;
            Voltar.Click += Voltar_Click;
            // 
            // dgvVeiculos
            // 
            dgvVeiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVeiculos.Location = new Point(29, 132);
            dgvVeiculos.Name = "dgvVeiculos";
            dgvVeiculos.Size = new Size(741, 284);
            dgvVeiculos.TabIndex = 4;
            // 
            // FrmVeiculosCadastrados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvVeiculos);
            Controls.Add(Voltar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnIncluir);
            Name = "FrmVeiculosCadastrados";
            Text = "Veiculos Cadastrados";
            Load += FrmVeiculosCadastrados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVeiculos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnIncluir;
        private Button btnEditar;
        private Button btnExcluir;
        private Button Voltar;
        private DataGridView dgvVeiculos;
    }
}