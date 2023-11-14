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
            lblTextoCod = new Label();
            lblValorTotal = new Label();
            label = new Label();
            btnBuscarCod = new Button();
            label2 = new Label();
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
            txtCodigoTransacao = new TextBox();
            lblTraco = new Label();
            splitContainer1 = new SplitContainer();
            btnImprimir = new Button();
            dgPagamento = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPagamento).BeginInit();
            SuspendLayout();
            // 
            // lblTextoCod
            // 
            lblTextoCod.Anchor = AnchorStyles.None;
            lblTextoCod.AutoSize = true;
            lblTextoCod.Location = new Point(329, 24);
            lblTextoCod.Name = "lblTextoCod";
            lblTextoCod.Size = new Size(160, 45);
            lblTextoCod.TabIndex = 52;
            lblTextoCod.Text = "* Codigo da Transação \r\nconsta em seu comprovante \r\nde reserva";
            // 
            // lblValorTotal
            // 
            lblValorTotal.Anchor = AnchorStyles.Left;
            lblValorTotal.AutoSize = true;
            lblValorTotal.Location = new Point(107, 221);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(44, 15);
            lblValorTotal.TabIndex = 51;
            lblValorTotal.Text = "R$ 0,00";
            // 
            // label
            // 
            label.Anchor = AnchorStyles.Left;
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label.ForeColor = Color.Black;
            label.Location = new Point(85, 230);
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
            btnBuscarCod.Location = new Point(204, 33);
            btnBuscarCod.Name = "btnBuscarCod";
            btnBuscarCod.Size = new Size(100, 23);
            btnBuscarCod.TabIndex = 49;
            btnBuscarCod.Text = "Buscar";
            btnBuscarCod.UseVisualStyleBackColor = false;
            btnBuscarCod.Click += btnBuscarCod_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(52, 38);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 48;
            label2.Text = "Forma de pagamento";
            // 
            // txtBanco
            // 
            txtBanco.Anchor = AnchorStyles.Left;
            txtBanco.BorderStyle = BorderStyle.None;
            txtBanco.Location = new Point(47, 185);
            txtBanco.Name = "txtBanco";
            txtBanco.PlaceholderText = "Banco";
            txtBanco.Size = new Size(70, 16);
            txtBanco.TabIndex = 45;
            // 
            // lblBanco
            // 
            lblBanco.Anchor = AnchorStyles.Left;
            lblBanco.AutoSize = true;
            lblBanco.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBanco.ForeColor = Color.Black;
            lblBanco.Location = new Point(45, 189);
            lblBanco.Name = "lblBanco";
            lblBanco.Size = new Size(72, 15);
            lblBanco.TabIndex = 46;
            lblBanco.Text = "_____________";
            // 
            // btnPagar
            // 
            btnPagar.Anchor = AnchorStyles.Left;
            btnPagar.BackColor = Color.Black;
            btnPagar.Cursor = Cursors.Hand;
            btnPagar.FlatStyle = FlatStyle.Popup;
            btnPagar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagar.ForeColor = Color.White;
            btnPagar.Location = new Point(80, 257);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(100, 23);
            btnPagar.TabIndex = 44;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // txtVencimento
            // 
            txtVencimento.Anchor = AnchorStyles.Left;
            txtVencimento.BorderStyle = BorderStyle.None;
            txtVencimento.Location = new Point(47, 134);
            txtVencimento.Name = "txtVencimento";
            txtVencimento.PlaceholderText = "Vencimento";
            txtVencimento.Size = new Size(70, 16);
            txtVencimento.TabIndex = 43;
            txtVencimento.KeyPress += txtVencimento_KeyPress;
            // 
            // lblVencimento
            // 
            lblVencimento.Anchor = AnchorStyles.Left;
            lblVencimento.AutoSize = true;
            lblVencimento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblVencimento.ForeColor = Color.Black;
            lblVencimento.Location = new Point(47, 139);
            lblVencimento.Name = "lblVencimento";
            lblVencimento.Size = new Size(72, 15);
            lblVencimento.TabIndex = 42;
            lblVencimento.Text = "_____________";
            // 
            // txtCod
            // 
            txtCod.Anchor = AnchorStyles.Left;
            txtCod.BorderStyle = BorderStyle.None;
            txtCod.Location = new Point(48, 161);
            txtCod.Name = "txtCod";
            txtCod.PlaceholderText = "Cod";
            txtCod.Size = new Size(26, 16);
            txtCod.TabIndex = 41;
            // 
            // lblCod
            // 
            lblCod.Anchor = AnchorStyles.Left;
            lblCod.AutoSize = true;
            lblCod.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCod.ForeColor = Color.Black;
            lblCod.Location = new Point(46, 165);
            lblCod.Name = "lblCod";
            lblCod.Size = new Size(32, 15);
            lblCod.TabIndex = 40;
            lblCod.Text = "_____";
            // 
            // txtCartao
            // 
            txtCartao.Anchor = AnchorStyles.Left;
            txtCartao.BorderStyle = BorderStyle.None;
            txtCartao.Location = new Point(47, 108);
            txtCartao.Name = "txtCartao";
            txtCartao.PlaceholderText = "Numero do cartão";
            txtCartao.Size = new Size(165, 16);
            txtCartao.TabIndex = 39;
            txtCartao.KeyPress += txtCartao_KeyPress;
            // 
            // lblCartao
            // 
            lblCartao.Anchor = AnchorStyles.Left;
            lblCartao.AutoSize = true;
            lblCartao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCartao.ForeColor = Color.Black;
            lblCartao.Location = new Point(45, 112);
            lblCartao.Name = "lblCartao";
            lblCartao.Size = new Size(167, 15);
            lblCartao.TabIndex = 38;
            lblCartao.Text = "________________________________";
            // 
            // cbPagamento
            // 
            cbPagamento.Anchor = AnchorStyles.Left;
            cbPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPagamento.FormattingEnabled = true;
            cbPagamento.Items.AddRange(new object[] { "Débito", "Crédito" });
            cbPagamento.Location = new Point(47, 56);
            cbPagamento.Name = "cbPagamento";
            cbPagamento.Size = new Size(132, 23);
            cbPagamento.TabIndex = 37;
            cbPagamento.SelectedIndexChanged += cbPagamento_SelectedIndexChanged;
            // 
            // txtCodigoTransacao
            // 
            txtCodigoTransacao.Anchor = AnchorStyles.None;
            txtCodigoTransacao.BackColor = Color.SeaShell;
            txtCodigoTransacao.BorderStyle = BorderStyle.None;
            txtCodigoTransacao.Location = new Point(61, 36);
            txtCodigoTransacao.Name = "txtCodigoTransacao";
            txtCodigoTransacao.PlaceholderText = "Codigo da Transação";
            txtCodigoTransacao.Size = new Size(119, 16);
            txtCodigoTransacao.TabIndex = 34;
            // 
            // lblTraco
            // 
            lblTraco.Anchor = AnchorStyles.None;
            lblTraco.AutoSize = true;
            lblTraco.BackColor = Color.Transparent;
            lblTraco.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTraco.ForeColor = Color.Black;
            lblTraco.Location = new Point(58, 41);
            lblTraco.Name = "lblTraco";
            lblTraco.Size = new Size(122, 15);
            lblTraco.TabIndex = 33;
            lblTraco.Text = "_______________________";
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
            splitContainer1.Panel1.BackColor = Color.White;
            splitContainer1.Panel1.Controls.Add(txtCodigoTransacao);
            splitContainer1.Panel1.Controls.Add(lblTextoCod);
            splitContainer1.Panel1.Controls.Add(btnBuscarCod);
            splitContainer1.Panel1.Controls.Add(lblTraco);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.White;
            splitContainer1.Panel2.Controls.Add(btnImprimir);
            splitContainer1.Panel2.Controls.Add(dgPagamento);
            splitContainer1.Panel2.Controls.Add(cbPagamento);
            splitContainer1.Panel2.Controls.Add(txtBanco);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(lblBanco);
            splitContainer1.Panel2.Controls.Add(lblValorTotal);
            splitContainer1.Panel2.Controls.Add(txtVencimento);
            splitContainer1.Panel2.Controls.Add(label);
            splitContainer1.Panel2.Controls.Add(lblVencimento);
            splitContainer1.Panel2.Controls.Add(btnPagar);
            splitContainer1.Panel2.Controls.Add(txtCod);
            splitContainer1.Panel2.Controls.Add(txtCartao);
            splitContainer1.Panel2.Controls.Add(lblCod);
            splitContainer1.Panel2.Controls.Add(lblCartao);
            splitContainer1.Size = new Size(589, 397);
            splitContainer1.SplitterDistance = 93;
            splitContainer1.TabIndex = 53;
            // 
            // btnImprimir
            // 
            btnImprimir.Anchor = AnchorStyles.Bottom;
            btnImprimir.BackColor = Color.Black;
            btnImprimir.Cursor = Cursors.Hand;
            btnImprimir.FlatStyle = FlatStyle.Popup;
            btnImprimir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnImprimir.ForeColor = Color.White;
            btnImprimir.Location = new Point(372, 257);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(100, 23);
            btnImprimir.TabIndex = 54;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            // 
            // dgPagamento
            // 
            dgPagamento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgPagamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPagamento.Location = new Point(254, 20);
            dgPagamento.Name = "dgPagamento";
            dgPagamento.RowTemplate.Height = 25;
            dgPagamento.Size = new Size(323, 225);
            dgPagamento.TabIndex = 53;
            // 
            // PagamentoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(589, 397);
            ControlBox = false;
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PagamentoView";
            Text = "Pagamento";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgPagamento).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtCodigoTransacao;
        private Label lblTraco;
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
        private Label label2;
        private Button btnBuscarCod;
        private Label lblValorTotal;
        private Label label;
        private Label lblTextoCod;
        private SplitContainer splitContainer1;
        private Button btnImprimir;
        private DataGridView dgPagamento;
    }
}