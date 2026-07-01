namespace Projeto.Integrador.View
{
    partial class FormExtrato
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
            dgvExtrato = new DataGridView();
            BtnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvExtrato).BeginInit();
            SuspendLayout();
            // 
            // dgvExtrato
            // 
            dgvExtrato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExtrato.Location = new Point(34, 47);
            dgvExtrato.Margin = new Padding(3, 4, 3, 4);
            dgvExtrato.Name = "dgvExtrato";
            dgvExtrato.RowHeadersWidth = 51;
            dgvExtrato.Size = new Size(767, 294);
            dgvExtrato.TabIndex = 0;
            // 
            // BtnVoltar
            // 
            BtnVoltar.Location = new Point(334, 365);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(149, 55);
            BtnVoltar.TabIndex = 2;
            BtnVoltar.Text = "Voltar";
            BtnVoltar.UseVisualStyleBackColor = true;
            BtnVoltar.Click += btnVoltar_Click;
            // 
            // FormExtrato
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 445);
            Controls.Add(BtnVoltar);
            Controls.Add(dgvExtrato);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormExtrato";
            Text = "FormExtrato";
            Load += FormExtrato_Load;
            ((System.ComponentModel.ISupportInitialize)dgvExtrato).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvExtrato;
        private Button BtnVoltar;
    }
}