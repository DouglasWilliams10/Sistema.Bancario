namespace Projeto.Integrador.View
{
    partial class FormDeposito
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeposito));
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            txtDataHora = new MaskedTextBox();
            tmrDataHora = new System.Windows.Forms.Timer(components);
            lblDataHora = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            imageList1 = new ImageList(components);
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 212);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Valor do Depósito";
            label1.Click += label1_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(25, 230);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(189, 23);
            maskedTextBox1.TabIndex = 1;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // txtDataHora
            // 
            txtDataHora.Location = new Point(528, 230);
            txtDataHora.Name = "txtDataHora";
            txtDataHora.Size = new Size(201, 23);
            txtDataHora.TabIndex = 2;
            txtDataHora.MaskInputRejected += txtDataHora_MaskInputRejected;
            // 
            // tmrDataHora
            // 
            tmrDataHora.Enabled = true;
            tmrDataHora.Interval = 1000;
            tmrDataHora.Tick += tmrDataHora_Tick;
            // 
            // lblDataHora
            // 
            lblDataHora.AutoSize = true;
            lblDataHora.Location = new Point(283, 230);
            lblDataHora.Name = "lblDataHora";
            lblDataHora.Size = new Size(139, 15);
            lblDataHora.TabIndex = 3;
            lblDataHora.Text = "Data e Hora da Operação";
            lblDataHora.Click += lblDataHora_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 64);
            label2.Name = "label2";
            label2.Size = new Size(190, 15);
            label2.TabIndex = 4;
            label2.Text = "Realize um depósito em sua conta.";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.DarkSeaGreen;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(387, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(185, 55);
            dataGridView1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 36);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 6;
            label3.Text = "Depósito";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = Color.WhiteSmoke;
            dataGridView2.Location = new Point(24, 99);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(548, 82);
            dataGridView2.TabIndex = 7;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "deposito-bancario.png");
            imageList1.Images.SetKeyName(1, "deposito-bancario.png");
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Location = new Point(284, 230);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 23);
            panel1.TabIndex = 8;
            // 
            // FormDeposito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dataGridView2);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(lblDataHora);
            Controls.Add(txtDataHora);
            Controls.Add(maskedTextBox1);
            Controls.Add(label1);
            Name = "FormDeposito";
            Text = "Depósito";
            TransparencyKey = Color.FromArgb(224, 224, 224);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox txtDataHora;
        private System.Windows.Forms.Timer tmrDataHora;
        private Label lblDataHora;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
        private DataGridView dataGridView2;
        private ImageList imageList1;
        private Panel panel1;
    }
}