namespace PrototipoProjetoInterdisciplinar.Views
{
    partial class CadastroClienteView
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
            label4 = new Label();
            txtNome = new TextBox();
            txtDocumento = new TextBox();
            label1 = new Label();
            txtEndereco = new TextBox();
            label3 = new Label();
            txtTelefone = new TextBox();
            label5 = new Label();
            txtModeloCarro = new TextBox();
            label6 = new Label();
            txtPlacaCarro = new TextBox();
            label7 = new Label();
            btnCadastroclt = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(57, 98);
            label4.Name = "label4";
            label4.Size = new Size(167, 15);
            label4.TabIndex = 26;
            label4.Text = "________________________________";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.None;
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Location = new Point(59, 94);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome Completo";
            txtNome.Size = new Size(167, 16);
            txtNome.TabIndex = 27;
            txtNome.KeyPress += txtNome_KeyPress;
            // 
            // txtDocumento
            // 
            txtDocumento.Anchor = AnchorStyles.None;
            txtDocumento.BorderStyle = BorderStyle.None;
            txtDocumento.Location = new Point(59, 130);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.PlaceholderText = "Documento";
            txtDocumento.Size = new Size(167, 16);
            txtDocumento.TabIndex = 29;
            txtDocumento.KeyPress += txtDocumento_KeyPress;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(57, 134);
            label1.Name = "label1";
            label1.Size = new Size(167, 15);
            label1.TabIndex = 28;
            label1.Text = "________________________________";
            // 
            // txtEndereco
            // 
            txtEndereco.Anchor = AnchorStyles.None;
            txtEndereco.BorderStyle = BorderStyle.None;
            txtEndereco.Location = new Point(59, 168);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PlaceholderText = "Endereço ";
            txtEndereco.Size = new Size(167, 16);
            txtEndereco.TabIndex = 31;
            txtEndereco.KeyPress += txtEndereco_KeyPress;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(57, 172);
            label3.Name = "label3";
            label3.Size = new Size(167, 15);
            label3.TabIndex = 30;
            label3.Text = "________________________________";
            // 
            // txtTelefone
            // 
            txtTelefone.Anchor = AnchorStyles.None;
            txtTelefone.BorderStyle = BorderStyle.None;
            txtTelefone.Location = new Point(59, 208);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "Telefone";
            txtTelefone.Size = new Size(167, 16);
            txtTelefone.TabIndex = 33;
            txtTelefone.KeyPress += txtTelefone_KeyPress;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(57, 212);
            label5.Name = "label5";
            label5.Size = new Size(167, 15);
            label5.TabIndex = 32;
            label5.Text = "________________________________";
            // 
            // txtModeloCarro
            // 
            txtModeloCarro.Anchor = AnchorStyles.None;
            txtModeloCarro.BorderStyle = BorderStyle.None;
            txtModeloCarro.Location = new Point(329, 95);
            txtModeloCarro.Name = "txtModeloCarro";
            txtModeloCarro.PlaceholderText = "Modelo do Carro";
            txtModeloCarro.Size = new Size(167, 16);
            txtModeloCarro.TabIndex = 35;
            txtModeloCarro.KeyPress += txtModeloCarro_KeyPress;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(327, 99);
            label6.Name = "label6";
            label6.Size = new Size(167, 15);
            label6.TabIndex = 34;
            label6.Text = "________________________________";
            // 
            // txtPlacaCarro
            // 
            txtPlacaCarro.Anchor = AnchorStyles.None;
            txtPlacaCarro.BorderStyle = BorderStyle.None;
            txtPlacaCarro.Location = new Point(329, 133);
            txtPlacaCarro.Name = "txtPlacaCarro";
            txtPlacaCarro.PlaceholderText = "Placa do Carro";
            txtPlacaCarro.Size = new Size(167, 16);
            txtPlacaCarro.TabIndex = 37;
            txtPlacaCarro.KeyPress += txtPlacaCarro_KeyPress;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(327, 137);
            label7.Name = "label7";
            label7.Size = new Size(167, 15);
            label7.TabIndex = 36;
            label7.Text = "________________________________";
            // 
            // btnCadastroclt
            // 
            btnCadastroclt.Anchor = AnchorStyles.None;
            btnCadastroclt.BackColor = Color.Black;
            btnCadastroclt.Cursor = Cursors.Hand;
            btnCadastroclt.FlatStyle = FlatStyle.Popup;
            btnCadastroclt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastroclt.ForeColor = Color.White;
            btnCadastroclt.Location = new Point(408, 201);
            btnCadastroclt.Name = "btnCadastroclt";
            btnCadastroclt.Size = new Size(88, 23);
            btnCadastroclt.TabIndex = 38;
            btnCadastroclt.Text = "Cadastrar";
            btnCadastroclt.UseVisualStyleBackColor = false;
            btnCadastroclt.Click += btnCadastroclt_Click;
            // 
            // CadastroClienteView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 330);
            ControlBox = false;
            Controls.Add(btnCadastroclt);
            Controls.Add(txtPlacaCarro);
            Controls.Add(label7);
            Controls.Add(txtModeloCarro);
            Controls.Add(label6);
            Controls.Add(txtTelefone);
            Controls.Add(label5);
            Controls.Add(txtEndereco);
            Controls.Add(label3);
            Controls.Add(txtDocumento);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CadastroClienteView";
            Text = "CadastroClienteView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private TextBox txtNome;
        private TextBox txtDocumento;
        private Label label1;
        private TextBox txtEndereco;
        private Label label3;
        private TextBox txtTelefone;
        private Label label5;
        private TextBox txtModeloCarro;
        private Label label6;
        private TextBox txtPlacaCarro;
        private Label label7;
        private Button btnCadastroclt;
    }
}