namespace Projeto.Integrador.View
{
    partial class FormRendimentos
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
            dgvRendimentos = new DataGridView();
            lblRendimentoTotal = new Label();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRendimentos).BeginInit();
            SuspendLayout();
            // 
            // dgvRendimentos
            // 
            dgvRendimentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRendimentos.Location = new Point(114, 72);
            dgvRendimentos.Name = "dgvRendimentos";
            dgvRendimentos.Size = new Size(527, 319);
            dgvRendimentos.TabIndex = 0;
            // 
            // lblRendimentoTotal
            // 
            lblRendimentoTotal.AutoSize = true;
            lblRendimentoTotal.Location = new Point(384, 29);
            lblRendimentoTotal.Name = "lblRendimentoTotal";
            lblRendimentoTotal.Size = new Size(38, 15);
            lblRendimentoTotal.TabIndex = 1;
            lblRendimentoTotal.Text = "label1";
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(604, 415);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FormRendimentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(lblRendimentoTotal);
            Controls.Add(dgvRendimentos);
            Name = "FormRendimentos";
            Text = "FormRendimentos";
            Load += FormRendimentos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRendimentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRendimentos;
        private Label lblRendimentoTotal;
        private Button btnVoltar;
    }
}