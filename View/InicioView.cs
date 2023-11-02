using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoProjetoInterdisciplinar.Views
{
    public partial class InicioView : Form
    {
        public InicioView()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja Sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroClienteView cdCliente = new CadastroClienteView();
            cdCliente.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(cdCliente);
            cdCliente.Dock = DockStyle.Fill;
            cdCliente.Show();
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja deslogar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                LoginView formLogin = new LoginView();
                formLogin.MdiParent = HomeView.ActiveForm;
                formLogin.Show();
            }
        }
    }
}
