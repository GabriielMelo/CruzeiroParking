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
            lblValorTotal = new Label();
            label = new Label();
            btnBuscarCod = new Button();
            label2 = new Label();
            label1 = new Label();
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
            btnBuscarNome = new Button();
            cbModoBusca = new ComboBox();
            txtCodigoTransacao = new TextBox();
            txtNome = new TextBox();
            lblTraco = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblValorTotal);
            panel1.Controls.Add(label);
            panel1.Controls.Add(btnBuscarCod);
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
            panel1.Controls.Add(btnBuscarNome);
            panel1.Controls.Add(cbModoBusca);
            panel1.Controls.Add(txtCodigoTransacao);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(lblTraco);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 366);
            panel1.TabIndex = 0;
            // 
            // lblValorTotal
            // 
            lblValorTotal.AutoSize = true;
            lblValorTotal.Location = new Point(400, 282);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(44, 15);
            lblValorTotal.TabIndex = 51;
            lblValorTotal.Text = "R$ 0,00";
            // 
            // label
            // 
            label.Anchor = AnchorStyles.None;
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label.ForeColor = Color.Black;
            label.Location = new Point(378, 285);
            label.Name = "label";
            label.Size = new Size(92, 15);
            label.TabIndex = 50;
            label.Text = "_________________";
            // 
            // btnBuscarCod
            // 
            btnBuscarCod.Anchor = AnchorStyles.None;
            btnBuscarCod.BackColor = Color.Black;
            btnBuscarCod.Cursor = Cursors.Hand;
            btnBuscarCod.FlatStyle = FlatStyle.Popup;
            btnBuscarCod.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarCod.ForeColor = Color.White;
            btnBuscarCod.Location = new Point(109, 166);
            btnBuscarCod.Name = "btnBuscarCod";
            btnBuscarCod.Size = new Size(100, 23);
            btnBuscarCod.TabIndex = 49;
            btnBuscarCod.Text = "Buscar";
            btnBuscarCod.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(342, 52);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 48;
            label2.Text = "Forma de pagamento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 52);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 47;
            label1.Text = "Buscar cliente por:";
            // 
            // txtBanco
            // 
            txtBanco.Anchor = AnchorStyles.None;
            txtBanco.BorderStyle = BorderStyle.None;
            txtBanco.Location = new Point(407, 202);
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
            lblBanco.Location = new Point(405, 206);
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
            btnPagar.Location = new Point(374, 309);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(100, 23);
            btnPagar.TabIndex = 44;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // txtVencimento
            // 
            txtVencimento.Anchor = AnchorStyles.None;
            txtVencimento.BorderStyle = BorderStyle.None;
            txtVencimento.Location = new Point(312, 171);
            txtVencimento.Name = "txtVencimento";
            txtVencimento.PlaceholderText = "Vencimento";
            txtVencimento.Size = new Size(70, 16);
            txtVencimento.TabIndex = 43;
            txtVencimento.KeyPress += txtVencimento_KeyPress;
            // 
            // lblVencimento
            // 
            lblVencimento.Anchor = AnchorStyles.None;
            lblVencimento.AutoSize = true;
            lblVencimento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblVencimento.ForeColor = Color.Black;
            lblVencimento.Location = new Point(310, 175);
            lblVencimento.Name = "lblVencimento";
            lblVencimento.Size = new Size(72, 15);
            lblVencimento.TabIndex = 42;
            lblVencimento.Text = "_____________";
            // 
            // txtCod
            // 
            txtCod.Anchor = AnchorStyles.None;
            txtCod.BorderStyle = BorderStyle.None;
            txtCod.Location = new Point(312, 202);
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
            lblCod.Location = new Point(310, 206);
            lblCod.Name = "lblCod";
            lblCod.Size = new Size(32, 15);
            lblCod.TabIndex = 40;
            lblCod.Text = "_____";
            // 
            // txtCartao
            // 
            txtCartao.Anchor = AnchorStyles.None;
            txtCartao.BorderStyle = BorderStyle.None;
            txtCartao.Location = new Point(312, 138);
            txtCartao.Name = "txtCartao";
            txtCartao.PlaceholderText = "Numero do cartão";
            txtCartao.Size = new Size(165, 16);
            txtCartao.TabIndex = 39;
            txtCartao.KeyPress += txtCartao_KeyPress;
            // 
            // lblCartao
            // 
            lblCartao.Anchor = AnchorStyles.None;
            lblCartao.AutoSize = true;
            lblCartao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCartao.ForeColor = Color.Black;
            lblCartao.Location = new Point(310, 142);
            lblCartao.Name = "lblCartao";
            lblCartao.Size = new Size(167, 15);
            lblCartao.TabIndex = 38;
            lblCartao.Text = "________________________________";
            // 
            // cbPagamento
            // 
            cbPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPagamento.FormattingEnabled = true;
            cbPagamento.Items.AddRange(new object[] { "Selecione", "Débito", "Crédito" });
            cbPagamento.Location = new Point(342, 70);
            cbPagamento.Name = "cbPagamento";
            cbPagamento.Size = new Size(132, 23);
            cbPagamento.TabIndex = 37;
            // 
            // btnBuscarNome
            // 
            btnBuscarNome.Anchor = AnchorStyles.None;
            btnBuscarNome.BackColor = Color.Black;
            btnBuscarNome.Cursor = Cursors.Hand;
            btnBuscarNome.FlatStyle = FlatStyle.Popup;
            btnBuscarNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarNome.ForeColor = Color.White;
            btnBuscarNome.Location = new Point(111, 166);
            btnBuscarNome.Name = "btnBuscarNome";
            btnBuscarNome.Size = new Size(100, 23);
            btnBuscarNome.TabIndex = 36;
            btnBuscarNome.Text = "Buscar";
            btnBuscarNome.UseVisualStyleBackColor = false;
            btnBuscarNome.Click += btnBuscarNome_Click;
            // 
            // cbModoBusca
            // 
            cbModoBusca.DropDownStyle = ComboBoxStyle.DropDownList;
            cbModoBusca.FormattingEnabled = true;
            cbModoBusca.Items.AddRange(new object[] { "Selecione", "Nome", "Codigo da transação" });
            cbModoBusca.Location = new Point(77, 70);
            cbModoBusca.Name = "cbModoBusca";
            cbModoBusca.Size = new Size(132, 23);
            cbModoBusca.TabIndex = 35;
            cbModoBusca.SelectedIndexChanged += cbModoBusca_SelectedIndexChanged;
            // 
            // txtCodigoTransacao
            // 
            txtCodigoTransacao.Anchor = AnchorStyles.None;
            txtCodigoTransacao.BackColor = Color.SeaShell;
            txtCodigoTransacao.BorderStyle = BorderStyle.None;
            txtCodigoTransacao.Location = new Point(90, 130);
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
            txtNome.Location = new Point(92, 130);
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
            lblTraco.Location = new Point(90, 135);
            lblTraco.Name = "lblTraco";
            lblTraco.Size = new Size(122, 15);
            lblTraco.TabIndex = 33;
            lblTraco.Text = "_______________________";
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
        private Button btnBuscarNome;
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
        private Button btnBuscarCod;
        private Label lblValorTotal;
        private Label label;
    }
}