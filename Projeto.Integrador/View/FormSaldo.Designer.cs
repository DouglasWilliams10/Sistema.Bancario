namespace Projeto.Integrador.View
{
    partial class FormSaldo
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
            lblSaldo = new Label();
            btnSacar = new Button();
            btnDepositar = new Button();
            btnSaldo = new Button();
            button1 = new Button();
            btnRendimentos = new Button();
            btnSair = new Button();
            lblBemVindo = new Label();
            SuspendLayout();
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(299, 62);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(69, 15);
            lblSaldo.TabIndex = 0;
            lblSaldo.Text = "Saldo conta";
            // 
            // btnSacar
            // 
            btnSacar.Location = new Point(41, 271);
            btnSacar.Name = "btnSacar";
            btnSacar.Size = new Size(75, 23);
            btnSacar.TabIndex = 1;
            btnSacar.Text = "SACAR";
            btnSacar.UseVisualStyleBackColor = true;
            btnSacar.Click += btnSacar_Click;
            // 
            // btnDepositar
            // 
            btnDepositar.Location = new Point(158, 271);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(75, 23);
            btnDepositar.TabIndex = 2;
            btnDepositar.Text = "DEPOSITAR";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // btnSaldo
            // 
            btnSaldo.Location = new Point(275, 272);
            btnSaldo.Name = "btnSaldo";
            btnSaldo.Size = new Size(75, 23);
            btnSaldo.TabIndex = 3;
            btnSaldo.Text = "EXTRATO";
            btnSaldo.UseVisualStyleBackColor = true;
            btnSaldo.Click += btnExtrato_Click;
            // 
            // button1
            // 
            button1.Location = new Point(545, 273);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 4;
            button1.Text = "Transferir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnTransferir_Click;
            // 
            // btnRendimentos
            // 
            btnRendimentos.Location = new Point(391, 273);
            btnRendimentos.Name = "btnRendimentos";
            btnRendimentos.Size = new Size(115, 23);
            btnRendimentos.TabIndex = 5;
            btnRendimentos.Text = "Rendimentos";
            btnRendimentos.UseVisualStyleBackColor = true;
            btnRendimentos.Click += btnRendimentos_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(645, 383);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 6;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // lblBemVindo
            // 
            lblBemVindo.AutoSize = true;
            lblBemVindo.Location = new Point(312, 102);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(38, 15);
            lblBemVindo.TabIndex = 7;
            lblBemVindo.Text = "label1";
            // 
            // FormSaldo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBemVindo);
            Controls.Add(btnSair);
            Controls.Add(btnRendimentos);
            Controls.Add(button1);
            Controls.Add(btnSaldo);
            Controls.Add(btnDepositar);
            Controls.Add(btnSacar);
            Controls.Add(lblSaldo);
            Name = "FormSaldo";
            Text = "TelaSaldo";
            Load += FormSaldo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSaldo;
        private Button btnSacar;
        private Button btnDepositar;
        private Button btnSaldo;
        private Button button1;
        private Button btnRendimentos;
        private Button btnSair;
        private Label lblBemVindo;
    }
}