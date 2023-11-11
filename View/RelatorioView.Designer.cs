namespace PrototipoProjetoInterdisciplinar.View
{
    partial class RelatorioView
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
            cb = new ComboBox();
            btnRelatorio = new Button();
            dataRelatorioClt = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataRelatorioClt).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(cb);
            splitContainer1.Panel1.Controls.Add(btnRelatorio);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataRelatorioClt);
            splitContainer1.Size = new Size(555, 401);
            splitContainer1.SplitterDistance = 87;
            splitContainer1.TabIndex = 0;
            // 
            // cb
            // 
            cb.Anchor = AnchorStyles.None;
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.FormattingEnabled = true;
            cb.Items.AddRange(new object[] { "Usuarios Cadastrados", "Historico de Reservas", "Faturamento Mensal", "" });
            cb.Location = new Point(98, 40);
            cb.Name = "cb";
            cb.Size = new Size(176, 23);
            cb.TabIndex = 28;
            // 
            // btnRelatorio
            // 
            btnRelatorio.Anchor = AnchorStyles.None;
            btnRelatorio.BackColor = Color.Black;
            btnRelatorio.Cursor = Cursors.Hand;
            btnRelatorio.FlatStyle = FlatStyle.Flat;
            btnRelatorio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRelatorio.ForeColor = Color.White;
            btnRelatorio.Location = new Point(310, 40);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(123, 29);
            btnRelatorio.TabIndex = 27;
            btnRelatorio.Text = "Gerar Relatorio";
            btnRelatorio.UseVisualStyleBackColor = false;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // dataRelatorioClt
            // 
            dataRelatorioClt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataRelatorioClt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataRelatorioClt.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataRelatorioClt.BorderStyle = BorderStyle.None;
            dataRelatorioClt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataRelatorioClt.Location = new Point(12, 15);
            dataRelatorioClt.Name = "dataRelatorioClt";
            dataRelatorioClt.RowTemplate.Height = 25;
            dataRelatorioClt.Size = new Size(531, 283);
            dataRelatorioClt.TabIndex = 0;
            // 
            // RelatorioView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 401);
            ControlBox = false;
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RelatorioView";
            Text = "Relatorios";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataRelatorioClt).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnRelatorio;
        private ComboBox cb;
        private DataGridView dataRelatorioClt;
    }
}