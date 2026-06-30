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
            label1 = new Label();
            lblUsuario_login = new Label();
            lblSenha_Login = new Label();
            btnEntrar_login = new Button();
            txtSenhaLogin = new TextBox();
            txtUsuarioLogin = new MaskedTextBox();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 91);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Bem Vindo(a)!";
            // 
            // lblUsuario_login
            // 
            lblUsuario_login.AutoSize = true;
            lblUsuario_login.Location = new Point(269, 136);
            lblUsuario_login.Name = "lblUsuario_login";
            lblUsuario_login.Size = new Size(28, 15);
            lblUsuario_login.TabIndex = 1;
            lblUsuario_login.Text = "CPF";
            // 
            // lblSenha_Login
            // 
            lblSenha_Login.AutoSize = true;
            lblSenha_Login.Location = new Point(269, 197);
            lblSenha_Login.Name = "lblSenha_Login";
            lblSenha_Login.Size = new Size(45, 15);
            lblSenha_Login.TabIndex = 2;
            lblSenha_Login.Text = "SENHA";
            // 
            // btnEntrar_login
            // 
            btnEntrar_login.Location = new Point(287, 283);
            btnEntrar_login.Name = "btnEntrar_login";
            btnEntrar_login.Size = new Size(75, 23);
            btnEntrar_login.TabIndex = 3;
            btnEntrar_login.Text = "ENTRAR";
            btnEntrar_login.UseVisualStyleBackColor = true;
            btnEntrar_login.Click += btnEntrar_login_Click;
            // 
            // txtSenhaLogin
            // 
            txtSenhaLogin.Location = new Point(269, 214);
            txtSenhaLogin.Margin = new Padding(3, 2, 3, 2);
            txtSenhaLogin.Name = "txtSenhaLogin";
            txtSenhaLogin.Size = new Size(110, 23);
            txtSenhaLogin.TabIndex = 2;
            txtSenhaLogin.UseSystemPasswordChar = true;
            // 
            // txtUsuarioLogin
            // 
            txtUsuarioLogin.Location = new Point(269, 153);
            txtUsuarioLogin.Margin = new Padding(3, 2, 3, 2);
            txtUsuarioLogin.Mask = "000\\.000\\.000\\-00";
            txtUsuarioLogin.Name = "txtUsuarioLogin";
            txtUsuarioLogin.Size = new Size(110, 23);
            txtUsuarioLogin.TabIndex = 1;
            txtUsuarioLogin.MaskInputRejected += txtUsuarioLogin_MaskInputRejected;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(231, 249);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(185, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Não possui cadastro? Clique aqui!";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 407);
            Controls.Add(linkLabel1);
            Controls.Add(txtUsuarioLogin);
            Controls.Add(txtSenhaLogin);
            Controls.Add(btnEntrar_login);
            Controls.Add(lblSenha_Login);
            Controls.Add(lblUsuario_login);
            Controls.Add(label1);
            Name = "FormLogin";
            Text = "TelaLogin";
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
    }
}
