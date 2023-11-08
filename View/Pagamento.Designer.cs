namespace PrototipoProjetoInterdisciplinar.View
{
    partial class Pagamento
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
            txtNome = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(37, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(498, 293);
            panel1.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.None;
            txtNome.BackColor = Color.SeaShell;
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Location = new Point(44, 116);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(167, 16);
            txtNome.TabIndex = 32;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(44, 120);
            label5.Name = "label5";
            label5.Size = new Size(167, 15);
            label5.TabIndex = 33;
            label5.Text = "________________________________";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = Color.SeaShell;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(44, 160);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nome";
            textBox1.Size = new Size(167, 16);
            textBox1.TabIndex = 34;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(44, 164);
            label1.Name = "label1";
            label1.Size = new Size(167, 15);
            label1.TabIndex = 35;
            label1.Text = "________________________________";
            // 
            // Pagamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(574, 390);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pagamentos";
            Text = "Pagamento";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Label label1;
        private TextBox txtNome;
        private Label label5;
    }
}