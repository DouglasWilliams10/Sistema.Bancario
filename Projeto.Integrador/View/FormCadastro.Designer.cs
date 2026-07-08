namespace Projeto.Integrador.View
{
    partial class FormCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            lbl_tela_cadastro = new Label();
            lblUsuario_Cadastro = new Label();
            lblSenha_Cadastro = new Label();
            btnCadastrar = new Button();
            btnVoltar_Cad = new Button();
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            txtSenha = new TextBox();
            txtConfirmarSenha = new TextBox();
            label3 = new Label();
            dtpDataNascimento = new DateTimePicker();
            label4 = new Label();
            txtSobrenome = new TextBox();
            txtCPF = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_tela_cadastro
            // 
            lbl_tela_cadastro.AutoSize = true;
            lbl_tela_cadastro.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_tela_cadastro.Location = new Point(243, 91);
            lbl_tela_cadastro.Name = "lbl_tela_cadastro";
            lbl_tela_cadastro.Size = new Size(186, 15);
            lbl_tela_cadastro.TabIndex = 0;
            lbl_tela_cadastro.Text = "Preencha os dados para continuar";
            lbl_tela_cadastro.Click += lbl_tela_cadastro_Click;
            // 
            // lblUsuario_Cadastro
            // 
            lblUsuario_Cadastro.AutoSize = true;
            lblUsuario_Cadastro.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblUsuario_Cadastro.Location = new Point(242, 136);
            lblUsuario_Cadastro.Name = "lblUsuario_Cadastro";
            lblUsuario_Cadastro.Size = new Size(40, 15);
            lblUsuario_Cadastro.TabIndex = 1;
            lblUsuario_Cadastro.Text = "Nome";
            lblUsuario_Cadastro.Click += lblUsuario_Cadastro_Click;
            // 
            // lblSenha_Cadastro
            // 
            lblSenha_Cadastro.AutoSize = true;
            lblSenha_Cadastro.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSenha_Cadastro.Location = new Point(242, 205);
            lblSenha_Cadastro.Name = "lblSenha_Cadastro";
            lblSenha_Cadastro.Size = new Size(27, 15);
            lblSenha_Cadastro.TabIndex = 2;
            lblSenha_Cadastro.Text = "CPF";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.PaleGreen;
            btnCadastrar.Location = new Point(245, 534);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(114, 31);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnVoltar_Cad
            // 
            btnVoltar_Cad.Location = new Point(377, 534);
            btnVoltar_Cad.Margin = new Padding(3, 4, 3, 4);
            btnVoltar_Cad.Name = "btnVoltar_Cad";
            btnVoltar_Cad.Size = new Size(86, 31);
            btnVoltar_Cad.TabIndex = 8;
            btnVoltar_Cad.Text = "VOLTAR";
            btnVoltar_Cad.UseVisualStyleBackColor = true;
            btnVoltar_Cad.Click += btnVoltar_Cad_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(242, 242);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 5;
            label1.Text = "Crie sua senha";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(242, 470);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 6;
            label2.Text = "Data de nascimento";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(351, 129);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 23);
            txtNome.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(352, 239);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(125, 23);
            txtSenha.TabIndex = 4;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(365, 430);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(125, 23);
            txtConfirmarSenha.TabIndex = 5;
            txtConfirmarSenha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(242, 436);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 12;
            label3.Text = "Confirmar senha";
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Location = new Point(392, 463);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(285, 23);
            dtpDataNascimento.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(242, 170);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 14;
            label4.Text = "Sobrenome";
            label4.Click += label4_Click;
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(349, 167);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(125, 23);
            txtSobrenome.TabIndex = 2;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(283, 200);
            txtCPF.Mask = "000\\.000\\.000\\-00";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(125, 23);
            txtCPF.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(245, 280);
            label5.Name = "label5";
            label5.Size = new Size(242, 15);
            label5.TabIndex = 16;
            label5.Text = "Deve ter, no mínimo, 6 caracteres, incluindo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(245, 310);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 17;
            label6.Text = "- 1 letra maiúscula";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(245, 340);
            label7.Name = "label7";
            label7.Size = new Size(105, 15);
            label7.TabIndex = 18;
            label7.Text = "- 1 letra minúscula";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(245, 371);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 19;
            label8.Text = "- 1 número";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(246, 398);
            label9.Name = "label9";
            label9.Size = new Size(186, 15);
            label9.TabIndex = 20;
            label9.Text = "- 1 caractere especial (@,$,!,%,*,?,&)";
            label9.Click += label9_Click;
            // 
            // FormCadastro
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(689, 600);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(txtCPF);
            Controls.Add(txtSobrenome);
            Controls.Add(label4);
            Controls.Add(dtpDataNascimento);
            Controls.Add(label3);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVoltar_Cad);
            Controls.Add(btnCadastrar);
            Controls.Add(lblSenha_Cadastro);
            Controls.Add(lblUsuario_Cadastro);
            Controls.Add(lbl_tela_cadastro);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCadastro";
            Text = "FormCadastro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_tela_cadastro;
        private Label lblUsuario_Cadastro;
        private Label lblSenha_Cadastro;
        private Button btnCadastrar;
        private Button btnVoltar_Cad;
        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private TextBox txtSenha;
        private TextBox txtConfirmarSenha;
        private Label label3;
        private DateTimePicker dtpDataNascimento;
        private Label label4;
        private TextBox txtSobrenome;
        private MaskedTextBox txtCPF;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}