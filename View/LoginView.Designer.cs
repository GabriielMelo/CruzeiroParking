namespace PrototipoProjetoInterdisciplinar.Views
{
    partial class LoginView
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
            splitContainer1 = new SplitContainer();
            label6 = new Label();
            label7 = new Label();
            label1 = new Label();
            txtUsuario = new TextBox();
            label5 = new Label();
            linkCadastro = new Label();
            label8 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            txtSenha = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Black;
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.Gainsboro;
            splitContainer1.Panel2.Controls.Add(txtUsuario);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(linkCadastro);
            splitContainer1.Panel2.Controls.Add(label8);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(btnLogin);
            splitContainer1.Panel2.Controls.Add(txtSenha);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Size = new Size(628, 379);
            splitContainer1.SplitterDistance = 131;
            splitContainer1.TabIndex = 0;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(50, 172);
            label6.Name = "label6";
            label6.Size = new Size(72, 25);
            label6.TabIndex = 20;
            label6.Text = "parking";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 141);
            label7.Name = "label7";
            label7.Size = new Size(98, 31);
            label7.TabIndex = 19;
            label7.Text = "Cruzeiro";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(27, 172);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 17;
            label1.Text = "label1";
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.None;
            txtUsuario.BackColor = Color.Gainsboro;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.Location = new Point(157, 148);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(167, 16);
            txtUsuario.TabIndex = 28;
            txtUsuario.KeyPress += txtUsuario_KeyPress_1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(162, 60);
            label5.Name = "label5";
            label5.Size = new Size(160, 38);
            label5.TabIndex = 16;
            label5.Text = "Bem Vindo!";
            // 
            // linkCadastro
            // 
            linkCadastro.Anchor = AnchorStyles.None;
            linkCadastro.AutoSize = true;
            linkCadastro.Cursor = Cursors.Hand;
            linkCadastro.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            linkCadastro.ForeColor = Color.Black;
            linkCadastro.Location = new Point(165, 335);
            linkCadastro.Name = "linkCadastro";
            linkCadastro.Size = new Size(157, 15);
            linkCadastro.TabIndex = 27;
            linkCadastro.Text = "Cadastrar novo Funcionario";
            linkCadastro.Click += linkCadastro_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(175, 98);
            label8.Name = "label8";
            label8.Size = new Size(126, 12);
            label8.TabIndex = 17;
            label8.Text = "Faça o login para continuar";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(155, 154);
            label3.Name = "label3";
            label3.Size = new Size(167, 15);
            label3.TabIndex = 24;
            label3.Text = "________________________________";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.Black;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(175, 253);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(123, 23);
            btnLogin.TabIndex = 26;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.None;
            txtSenha.BackColor = Color.Gainsboro;
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtSenha.ForeColor = Color.Black;
            txtSenha.Location = new Point(158, 205);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(167, 16);
            txtSenha.TabIndex = 23;
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.KeyPress += txtSenha_KeyPress_1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(155, 209);
            label4.Name = "label4";
            label4.Size = new Size(167, 15);
            label4.TabIndex = 25;
            label4.Text = "________________________________";
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 379);
            Controls.Add(splitContainer1);
            Name = "LoginView";
            Text = "Login - Cruzeiro Parking";
            WindowState = FormWindowState.Maximized;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label6;
        private Label label7;
        private Label label1;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtSenha;
        private Button btnLogin;
        private Label linkCadastro;
        private TextBox txtUsuario;
    }
}