using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace PrototipoProjetoInterdisciplinar.Views
{
    public partial class HomeView : Form
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void btnAcess_Click(object sender, EventArgs e)
        {
            gpBox.Hide();
            LoginView formLogin = new LoginView();
            formLogin.MdiParent = this;
            formLogin.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            string link = "https://github.com/GabriielMelo/Projeto_ADS3_GRP7";

            try
            {
                System.Diagnostics.Process.Start("cmd", $"/c start {link}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o link: " + ex.Message);
            }
        }
    }
}
