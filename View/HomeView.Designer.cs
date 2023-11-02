namespace PrototipoProjetoInterdisciplinar.Views
{
    partial class HomeView
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
            gpBox = new GroupBox();
            splitContainer1 = new SplitContainer();
            label6 = new Label();
            label7 = new Label();
            label1 = new Label();
            btnAcess = new Button();
            label3 = new Label();
            gpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // gpBox
            // 
            gpBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gpBox.Controls.Add(splitContainer1);
            gpBox.Location = new Point(-2, -24);
            gpBox.Name = "gpBox";
            gpBox.Size = new Size(660, 467);
            gpBox.TabIndex = 0;
            gpBox.TabStop = false;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 19);
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
            splitContainer1.Panel2.Controls.Add(btnAcess);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Size = new Size(654, 445);
            splitContainer1.SplitterDistance = 169;
            splitContainer1.TabIndex = 0;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(72, 218);
            label6.Name = "label6";
            label6.Size = new Size(72, 25);
            label6.TabIndex = 16;
            label6.Text = "parking";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(25, 187);
            label7.Name = "label7";
            label7.Size = new Size(98, 31);
            label7.TabIndex = 15;
            label7.Text = "Cruzeiro";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(49, 218);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 13;
            label1.Text = "label1";
            // 
            // btnAcess
            // 
            btnAcess.Anchor = AnchorStyles.None;
            btnAcess.Cursor = Cursors.Hand;
            btnAcess.FlatStyle = FlatStyle.Popup;
            btnAcess.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAcess.ForeColor = Color.Black;
            btnAcess.Location = new Point(183, 331);
            btnAcess.Name = "btnAcess";
            btnAcess.Size = new Size(145, 46);
            btnAcess.TabIndex = 1;
            btnAcess.Text = "Acessar";
            btnAcess.UseVisualStyleBackColor = true;
            btnAcess.Click += btnAcess_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(76, 57);
            label3.Name = "label3";
            label3.Size = new Size(312, 225);
            label3.TabIndex = 0;
            label3.Text = "Projeto Interdisciplinar III Turma 7.\r\n\r\nIntegrantes : \r\n\r\nGabriel de Jesus Melo RGM 31465196\r\nWilliam Ribeiro  RGM\r\nMarcela Penna \r\nDeivirt \r\nMarcelo Santos\r\n";
            // 
            // HomeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 437);
            Controls.Add(gpBox);
            IsMdiContainer = true;
            Name = "HomeView";
            Text = "HomeView";
            WindowState = FormWindowState.Maximized;
            gpBox.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpBox;
        private SplitContainer splitContainer1;
        private Label label6;
        private Label label7;
        private Label label1;
        private Button btnAcess;
        private Label label3;
    }
}