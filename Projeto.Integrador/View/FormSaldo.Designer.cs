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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSaldo));
            lblSaldo = new Label();
            btnSacar = new Button();
            btnDepositar = new Button();
            btnSaldo = new Button();
            button1 = new Button();
            btnRendimentos = new Button();
            btnSair = new Button();
            lblBemVindo = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaldo.Location = new Point(44, 95);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(158, 28);
            lblSaldo.TabIndex = 0;
            lblSaldo.Text = "Saldo em conta";
            lblSaldo.Click += lblSaldo_Click;
            // 
            // btnSacar
            // 
            btnSacar.Location = new Point(325, 344);
            btnSacar.Margin = new Padding(3, 4, 3, 4);
            btnSacar.Name = "btnSacar";
            btnSacar.Size = new Size(86, 31);
            btnSacar.TabIndex = 1;
            btnSacar.Text = "Sacar";
            btnSacar.UseVisualStyleBackColor = true;
            btnSacar.Click += btnSacar_Click;
            // 
            // btnDepositar
            // 
            btnDepositar.Location = new Point(115, 344);
            btnDepositar.Margin = new Padding(3, 4, 3, 4);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(86, 31);
            btnDepositar.TabIndex = 2;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // btnSaldo
            // 
            btnSaldo.Location = new Point(44, 171);
            btnSaldo.Margin = new Padding(3, 4, 3, 4);
            btnSaldo.Name = "btnSaldo";
            btnSaldo.Size = new Size(86, 31);
            btnSaldo.TabIndex = 3;
            btnSaldo.Text = "Extrato";
            btnSaldo.UseVisualStyleBackColor = true;
            btnSaldo.Click += btnExtrato_Click;
            // 
            // button1
            // 
            button1.Location = new Point(535, 345);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Transferir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnTransferir_Click;
            // 
            // btnRendimentos
            // 
            btnRendimentos.Location = new Point(44, 220);
            btnRendimentos.Margin = new Padding(3, 4, 3, 4);
            btnRendimentos.Name = "btnRendimentos";
            btnRendimentos.Size = new Size(131, 31);
            btnRendimentos.TabIndex = 5;
            btnRendimentos.Text = "Rendimentos";
            btnRendimentos.UseVisualStyleBackColor = true;
            btnRendimentos.Click += btnRendimentos_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(605, 514);
            btnSair.Margin = new Padding(3, 4, 3, 4);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(86, 31);
            btnSair.TabIndex = 6;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // lblBemVindo
            // 
            lblBemVindo.AutoSize = true;
            lblBemVindo.Location = new Point(44, 65);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(50, 20);
            lblBemVindo.TabIndex = 7;
            lblBemVindo.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(549, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Image = Properties.Resources.caixa_de_deposito;
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(51, 329);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.WaitOnLoad = true;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.ErrorImage = (Image)resources.GetObject("pictureBox4.ErrorImage");
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.InitialImage = (Image)resources.GetObject("pictureBox4.InitialImage");
            pictureBox4.Location = new Point(471, 329);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 55);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            pictureBox4.WaitOnLoad = true;
            // 
            // pictureBox5
            // 
            pictureBox5.ErrorImage = (Image)resources.GetObject("pictureBox5.ErrorImage");
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.InitialImage = (Image)resources.GetObject("pictureBox5.InitialImage");
            pictureBox5.Location = new Point(261, 329);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(58, 55);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            pictureBox5.WaitOnLoad = true;
            // 
            // FormSaldo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 600);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblBemVindo);
            Controls.Add(btnSair);
            Controls.Add(btnRendimentos);
            Controls.Add(button1);
            Controls.Add(btnSaldo);
            Controls.Add(btnDepositar);
            Controls.Add(btnSacar);
            Controls.Add(lblSaldo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormSaldo";
            Text = "TelaSaldo";
            Load += FormSaldo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}