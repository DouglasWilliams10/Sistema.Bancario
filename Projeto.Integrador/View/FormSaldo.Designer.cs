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
            SuspendLayout();
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(342, 83);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(88, 20);
            lblSaldo.TabIndex = 0;
            lblSaldo.Text = "Saldo conta";
            // 
            // btnSacar
            // 
            btnSacar.Location = new Point(47, 361);
            btnSacar.Margin = new Padding(3, 4, 3, 4);
            btnSacar.Name = "btnSacar";
            btnSacar.Size = new Size(86, 31);
            btnSacar.TabIndex = 1;
            btnSacar.Text = "SACAR";
            btnSacar.UseVisualStyleBackColor = true;
            btnSacar.Click += btnSacar_Click;
            // 
            // btnDepositar
            // 
            btnDepositar.Location = new Point(180, 361);
            btnDepositar.Margin = new Padding(3, 4, 3, 4);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(86, 31);
            btnDepositar.TabIndex = 2;
            btnDepositar.Text = "DEPOSITAR";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // btnSaldo
            // 
            btnSaldo.Location = new Point(314, 363);
            btnSaldo.Margin = new Padding(3, 4, 3, 4);
            btnSaldo.Name = "btnSaldo";
            btnSaldo.Size = new Size(86, 31);
            btnSaldo.TabIndex = 3;
            btnSaldo.Text = "EXTRATO";
            btnSaldo.UseVisualStyleBackColor = true;
            btnSaldo.Click += btnExtrato_Click;
            // 
            // button1
            // 
            button1.Location = new Point(630, 365);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Transferir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnTransferir_Click;
            // 
            // FormSaldo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button1);
            Controls.Add(btnSaldo);
            Controls.Add(btnDepositar);
            Controls.Add(btnSacar);
            Controls.Add(lblSaldo);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}