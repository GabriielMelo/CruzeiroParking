namespace PrototipoProjetoInterdisciplinar.Views
{
    partial class InicioView
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
            splitContainer2 = new SplitContainer();
            btnSair = new Button();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            btnCadastrar = new Button();
            btnLogoff = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(687, 367);
            splitContainer1.SplitterDistance = 70;
            splitContainer1.TabIndex = 0;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(583, 31);
            label6.Name = "label6";
            label6.Size = new Size(72, 25);
            label6.TabIndex = 23;
            label6.Text = "parking";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(536, 0);
            label7.Name = "label7";
            label7.Size = new Size(98, 31);
            label7.TabIndex = 22;
            label7.Text = "Cruzeiro";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(560, 31);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 21;
            label1.Text = "label1";
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = Color.Black;
            splitContainer2.Panel1.Controls.Add(btnLogoff);
            splitContainer2.Panel1.Controls.Add(btnSair);
            splitContainer2.Panel1.Controls.Add(button3);
            splitContainer2.Panel1.Controls.Add(button4);
            splitContainer2.Panel1.Controls.Add(button2);
            splitContainer2.Panel1.Controls.Add(btnCadastrar);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = Color.Gainsboro;
            splitContainer2.Size = new Size(687, 293);
            splitContainer2.SplitterDistance = 133;
            splitContainer2.TabIndex = 0;
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.None;
            btnSair.Cursor = Cursors.Hand;
            btnSair.FlatStyle = FlatStyle.Popup;
            btnSair.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.ForeColor = Color.Gainsboro;
            btnSair.Location = new Point(3, 249);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(127, 41);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Gainsboro;
            button3.Location = new Point(3, 155);
            button3.Name = "button3";
            button3.Size = new Size(127, 41);
            button3.TabIndex = 4;
            button3.Text = "Pagamentos";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Gainsboro;
            button4.Location = new Point(3, 108);
            button4.Name = "button4";
            button4.Size = new Size(127, 41);
            button4.TabIndex = 3;
            button4.Text = "Relatorios";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Gainsboro;
            button2.Location = new Point(3, 61);
            button2.Name = "button2";
            button2.Size = new Size(127, 41);
            button2.TabIndex = 1;
            button2.Text = "Consultar Vagas";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.None;
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.FlatStyle = FlatStyle.Popup;
            btnCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.ForeColor = Color.Gainsboro;
            btnCadastrar.Location = new Point(3, 14);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(127, 41);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar Clientes";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnLogoff
            // 
            btnLogoff.Anchor = AnchorStyles.None;
            btnLogoff.Cursor = Cursors.Hand;
            btnLogoff.FlatStyle = FlatStyle.Popup;
            btnLogoff.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogoff.ForeColor = Color.Gainsboro;
            btnLogoff.Location = new Point(3, 202);
            btnLogoff.Name = "btnLogoff";
            btnLogoff.Size = new Size(127, 41);
            btnLogoff.TabIndex = 6;
            btnLogoff.Text = "Logoff";
            btnLogoff.UseVisualStyleBackColor = true;
            btnLogoff.Click += btnLogoff_Click;
            // 
            // InicioView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 367);
            Controls.Add(splitContainer1);
            Name = "InicioView";
            Text = "InicioView";
            WindowState = FormWindowState.Maximized;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Label label6;
        private Label label7;
        private Label label1;
        private Button button3;
        private Button button4;
        private Button button2;
        private Button btnCadastrar;
        private Button btnSair;
        private Button btnLogoff;
    }
}