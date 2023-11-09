namespace PrototipoProjetoInterdisciplinar.View
{
    partial class PagamentoView
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
            panel1 = new Panel();
            txtBanco = new TextBox();
            lblBanco = new Label();
            btnPagar = new Button();
            txtVencimento = new TextBox();
            lblVencimento = new Label();
            txtCod = new TextBox();
            lblCod = new Label();
            txtCartao = new TextBox();
            lblCartao = new Label();
            cbPagamento = new ComboBox();
            btnBuscar = new Button();
            cbModoBusca = new ComboBox();
            txtCodigoTransacao = new TextBox();
            txtNome = new TextBox();
            lblTraco = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtBanco);
            panel1.Controls.Add(lblBanco);
            panel1.Controls.Add(btnPagar);
            panel1.Controls.Add(txtVencimento);
            panel1.Controls.Add(lblVencimento);
            panel1.Controls.Add(txtCod);
            panel1.Controls.Add(lblCod);
            panel1.Controls.Add(txtCartao);
            panel1.Controls.Add(lblCartao);
            panel1.Controls.Add(cbPagamento);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(cbModoBusca);
            panel1.Controls.Add(txtCodigoTransacao);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(lblTraco);
            panel1.Location = new Point(37, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(498, 293);
            panel1.TabIndex = 0;
            // 
            // txtBanco
            // 
            txtBanco.Anchor = AnchorStyles.None;
            txtBanco.BorderStyle = BorderStyle.None;
            txtBanco.Location = new Point(178, 236);
            txtBanco.Name = "txtBanco";
            txtBanco.PlaceholderText = "Banco";
            txtBanco.Size = new Size(70, 16);
            txtBanco.TabIndex = 45;
            // 
            // lblBanco
            // 
            lblBanco.Anchor = AnchorStyles.None;
            lblBanco.AutoSize = true;
            lblBanco.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBanco.ForeColor = Color.Black;
            lblBanco.Location = new Point(176, 240);
            lblBanco.Name = "lblBanco";
            lblBanco.Size = new Size(72, 15);
            lblBanco.TabIndex = 46;
            lblBanco.Text = "_____________";
            // 
            // btnPagar
            // 
            btnPagar.Anchor = AnchorStyles.None;
            btnPagar.BackColor = Color.Black;
            btnPagar.Cursor = Cursors.Hand;
            btnPagar.FlatStyle = FlatStyle.Popup;
            btnPagar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagar.ForeColor = Color.White;
            btnPagar.Location = new Point(313, 229);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(100, 23);
            btnPagar.TabIndex = 44;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            // 
            // txtVencimento
            // 
            txtVencimento.Anchor = AnchorStyles.None;
            txtVencimento.BorderStyle = BorderStyle.None;
            txtVencimento.Location = new Point(83, 205);
            txtVencimento.Name = "txtVencimento";
            txtVencimento.PlaceholderText = "Vencimento";
            txtVencimento.Size = new Size(70, 16);
            txtVencimento.TabIndex = 43;
            // 
            // lblVencimento
            // 
            lblVencimento.Anchor = AnchorStyles.None;
            lblVencimento.AutoSize = true;
            lblVencimento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblVencimento.ForeColor = Color.Black;
            lblVencimento.Location = new Point(81, 209);
            lblVencimento.Name = "lblVencimento";
            lblVencimento.Size = new Size(72, 15);
            lblVencimento.TabIndex = 42;
            lblVencimento.Text = "_____________";
            // 
            // txtCod
            // 
            txtCod.Anchor = AnchorStyles.None;
            txtCod.BorderStyle = BorderStyle.None;
            txtCod.Location = new Point(83, 236);
            txtCod.Name = "txtCod";
            txtCod.PlaceholderText = "Cod";
            txtCod.Size = new Size(26, 16);
            txtCod.TabIndex = 41;
            // 
            // lblCod
            // 
            lblCod.Anchor = AnchorStyles.None;
            lblCod.AutoSize = true;
            lblCod.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCod.ForeColor = Color.Black;
            lblCod.Location = new Point(81, 240);
            lblCod.Name = "lblCod";
            lblCod.Size = new Size(32, 15);
            lblCod.TabIndex = 40;
            lblCod.Text = "_____";
            // 
            // txtCartao
            // 
            txtCartao.Anchor = AnchorStyles.None;
            txtCartao.BorderStyle = BorderStyle.None;
            txtCartao.Location = new Point(83, 172);
            txtCartao.Name = "txtCartao";
            txtCartao.PlaceholderText = "Numero do cartão";
            txtCartao.Size = new Size(165, 16);
            txtCartao.TabIndex = 39;
            // 
            // lblCartao
            // 
            lblCartao.Anchor = AnchorStyles.None;
            lblCartao.AutoSize = true;
            lblCartao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCartao.ForeColor = Color.Black;
            lblCartao.Location = new Point(81, 176);
            lblCartao.Name = "lblCartao";
            lblCartao.Size = new Size(167, 15);
            lblCartao.TabIndex = 38;
            lblCartao.Text = "________________________________";
            // 
            // cbPagamento
            // 
            cbPagamento.FormattingEnabled = true;
            cbPagamento.Items.AddRange(new object[] { "Débito", "Crédito" });
            cbPagamento.Location = new Point(83, 108);
            cbPagamento.Name = "cbPagamento";
            cbPagamento.Size = new Size(132, 23);
            cbPagamento.TabIndex = 37;
            cbPagamento.Text = "Selecione";
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.None;
            btnBuscar.BackColor = Color.Black;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(313, 107);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(100, 23);
            btnBuscar.TabIndex = 36;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // cbModoBusca
            // 
            cbModoBusca.FormattingEnabled = true;
            cbModoBusca.Items.AddRange(new object[] { "Por Nome", "Por Codigo da transação" });
            cbModoBusca.Location = new Point(83, 51);
            cbModoBusca.Name = "cbModoBusca";
            cbModoBusca.Size = new Size(132, 23);
            cbModoBusca.TabIndex = 35;
            cbModoBusca.Text = "Selecione";
            // 
            // txtCodigoTransacao
            // 
            txtCodigoTransacao.Anchor = AnchorStyles.None;
            txtCodigoTransacao.BackColor = Color.SeaShell;
            txtCodigoTransacao.BorderStyle = BorderStyle.None;
            txtCodigoTransacao.Location = new Point(292, 51);
            txtCodigoTransacao.Name = "txtCodigoTransacao";
            txtCodigoTransacao.PlaceholderText = "Codigo da Transação";
            txtCodigoTransacao.Size = new Size(119, 16);
            txtCodigoTransacao.TabIndex = 34;
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.None;
            txtNome.BackColor = Color.SeaShell;
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Location = new Point(294, 51);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(120, 16);
            txtNome.TabIndex = 32;
            // 
            // lblTraco
            // 
            lblTraco.Anchor = AnchorStyles.None;
            lblTraco.AutoSize = true;
            lblTraco.BackColor = Color.Transparent;
            lblTraco.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTraco.ForeColor = Color.Black;
            lblTraco.Location = new Point(292, 56);
            lblTraco.Name = "lblTraco";
            lblTraco.Size = new Size(122, 15);
            lblTraco.TabIndex = 33;
            lblTraco.Text = "_______________________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 33);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 47;
            label1.Text = "Buscar cliente por:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 90);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 48;
            label2.Text = "Forma de pagamento";
            // 
            // PagamentoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(574, 390);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PagamentoView";
            Text = "Pagamento";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtCodigoTransacao;
        private TextBox txtNome;
        private Label lblTraco;
        private ComboBox cbModoBusca;
        private Button btnBuscar;
        private ComboBox cbPagamento;
        private TextBox txtVencimento;
        private Label lblVencimento;
        private TextBox txtCod;
        private Label lblCod;
        private TextBox txtCartao;
        private Label lblCartao;
        private Button btnPagar;
        private TextBox txtBanco;
        private Label lblBanco;
        private Label label1;
        private Label label2;
    }
}