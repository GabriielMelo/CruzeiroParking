namespace PrototipoProjetoInterdisciplinar.Views
{
    partial class CadastroFuncionarioView
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
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            label1 = new Label();
            label5 = new Label();
            btnVoltar = new Button();
            btnCadastrar = new Button();
            label8 = new Label();
            txtUsuario = new TextBox();
            label4 = new Label();
            txtSenha = new TextBox();
            txtNome = new TextBox();
            txtSenhaConfirm = new TextBox();
            label3 = new Label();
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
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Black;
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.Gainsboro;
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(btnVoltar);
            splitContainer1.Panel2.Controls.Add(btnCadastrar);
            splitContainer1.Panel2.Controls.Add(label8);
            splitContainer1.Panel2.Controls.Add(txtUsuario);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(txtSenha);
            splitContainer1.Panel2.Controls.Add(txtNome);
            splitContainer1.Panel2.Controls.Add(txtSenhaConfirm);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Size = new Size(572, 425);
            splitContainer1.SplitterDistance = 83;
            splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 27);
            label2.Name = "label2";
            label2.Size = new Size(233, 28);
            label2.TabIndex = 20;
            label2.Text = "Cadastro de Funcionários";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(481, 40);
            label6.Name = "label6";
            label6.Size = new Size(72, 25);
            label6.TabIndex = 19;
            label6.Text = "parking";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(434, 9);
            label7.Name = "label7";
            label7.Size = new Size(98, 31);
            label7.TabIndex = 18;
            label7.Text = "Cruzeiro";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(458, 40);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 17;
            label1.Text = "label1";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(212, 51);
            label5.Name = "label5";
            label5.Size = new Size(167, 15);
            label5.TabIndex = 31;
            label5.Text = "________________________________";
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.None;
            btnVoltar.BackColor = Color.Black;
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.FlatStyle = FlatStyle.Popup;
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(181, 237);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 31);
            btnVoltar.TabIndex = 30;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.None;
            btnCadastrar.BackColor = Color.Black;
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.FlatStyle = FlatStyle.Popup;
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(325, 237);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(77, 30);
            btnCadastrar.TabIndex = 29;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.BackColor = Color.Gainsboro;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(212, 174);
            label8.Name = "label8";
            label8.Size = new Size(167, 15);
            label8.TabIndex = 28;
            label8.Text = "________________________________";
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.None;
            txtUsuario.BackColor = Color.Gainsboro;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Location = new Point(212, 79);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(167, 16);
            txtUsuario.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Gainsboro;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(212, 89);
            label4.Name = "label4";
            label4.Size = new Size(167, 15);
            label4.TabIndex = 26;
            label4.Text = "________________________________";
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.None;
            txtSenha.BackColor = Color.Gainsboro;
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Location = new Point(212, 118);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(167, 16);
            txtSenha.TabIndex = 2;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.None;
            txtNome.BackColor = Color.Gainsboro;
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Location = new Point(212, 32);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(167, 16);
            txtNome.TabIndex = 0;
            // 
            // txtSenhaConfirm
            // 
            txtSenhaConfirm.Anchor = AnchorStyles.None;
            txtSenhaConfirm.BackColor = Color.Gainsboro;
            txtSenhaConfirm.BorderStyle = BorderStyle.None;
            txtSenhaConfirm.Location = new Point(212, 155);
            txtSenhaConfirm.Name = "txtSenhaConfirm";
            txtSenhaConfirm.PlaceholderText = "Confirmar Senha";
            txtSenhaConfirm.Size = new Size(167, 16);
            txtSenhaConfirm.TabIndex = 3;
            txtSenhaConfirm.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Gainsboro;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(212, 128);
            label3.Name = "label3";
            label3.Size = new Size(167, 15);
            label3.TabIndex = 25;
            label3.Text = "________________________________";
            // 
            // CadastroFuncionarioView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 425);
            Controls.Add(splitContainer1);
            Name = "CadastroFuncionarioView";
            Text = "CadastroFuncionarioView";
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
        private Label label2;
        private Label label6;
        private Label label7;
        private Label label1;
        private TextBox txtNome;
        private TextBox txtSenhaConfirm;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label label4;
        private Label label3;
        private Label label8;
        private Button btnVoltar;
        private Button btnCadastrar;
        private Label label5;
    }
}