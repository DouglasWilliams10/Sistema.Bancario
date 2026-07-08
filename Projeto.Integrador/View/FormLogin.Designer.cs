namespace Projeto.Integrador.View
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            label1 = new Label();
            lblUsuario_login = new Label();
            lblSenha_Login = new Label();
            btnEntrar_login = new Button();
            txtSenhaLogin = new TextBox();
            txtUsuarioLogin = new MaskedTextBox();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 143);
            label1.Name = "label1";
            label1.Size = new Size(223, 20);
            label1.TabIndex = 0;
            label1.Text = "Bem-vindo(a)! Acesse sua conta:";
            // 
            // lblUsuario_login
            // 
            lblUsuario_login.AutoSize = true;
            lblUsuario_login.Location = new Point(307, 181);
            lblUsuario_login.Name = "lblUsuario_login";
            lblUsuario_login.Size = new Size(33, 20);
            lblUsuario_login.TabIndex = 1;
            lblUsuario_login.Text = "CPF";
            // 
            // lblSenha_Login
            // 
            lblSenha_Login.AutoSize = true;
            lblSenha_Login.Location = new Point(307, 263);
            lblSenha_Login.Name = "lblSenha_Login";
            lblSenha_Login.Size = new Size(57, 20);
            lblSenha_Login.TabIndex = 2;
            lblSenha_Login.Text = "SENHA";
            // 
            // btnEntrar_login
            // 
            btnEntrar_login.BackColor = SystemColors.ActiveCaption;
            btnEntrar_login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar_login.Location = new Point(328, 377);
            btnEntrar_login.Margin = new Padding(3, 4, 3, 4);
            btnEntrar_login.Name = "btnEntrar_login";
            btnEntrar_login.Size = new Size(86, 31);
            btnEntrar_login.TabIndex = 3;
            btnEntrar_login.Text = "ENTRAR";
            btnEntrar_login.UseVisualStyleBackColor = false;
            btnEntrar_login.Click += btnEntrar_login_Click;
            // 
            // txtSenhaLogin
            // 
            txtSenhaLogin.Location = new Point(307, 285);
            txtSenhaLogin.Name = "txtSenhaLogin";
            txtSenhaLogin.Size = new Size(125, 27);
            txtSenhaLogin.TabIndex = 2;
            txtSenhaLogin.UseSystemPasswordChar = true;
            txtSenhaLogin.TextChanged += txtSenhaLogin_TextChanged;
            // 
            // txtUsuarioLogin
            // 
            txtUsuarioLogin.Location = new Point(307, 204);
            txtUsuarioLogin.Mask = "000\\.000\\.000\\-00";
            txtUsuarioLogin.Name = "txtUsuarioLogin";
            txtUsuarioLogin.Size = new Size(125, 27);
            txtUsuarioLogin.TabIndex = 1;
            txtUsuarioLogin.MaskInputRejected += txtUsuarioLogin_MaskInputRejected;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(238, 334);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(291, 20);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Não possui cadastro? Abra sua conta aqui!";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 543);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(txtUsuarioLogin);
            Controls.Add(txtSenhaLogin);
            Controls.Add(btnEntrar_login);
            Controls.Add(lblSenha_Login);
            Controls.Add(lblUsuario_login);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormLogin";
            Text = "TelaLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblUsuario_login;
        private Label lblSenha_Login;
        private Button btnEntrar_login;
        private TextBox txtSenhaLogin;
        private MaskedTextBox txtUsuarioLogin;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
    }
}
