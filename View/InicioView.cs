using PrototipoProjetoInterdisciplinar.View;
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
            txtBemVindo.Show();
            txtCadastroclt.Hide();
            txtConsultarVagas.Hide();
            txtRelatorios.Hide();
            txtPagamentos.Hide();
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
            txtBemVindo.Hide();
            txtCadastroclt.Show();
            txtConsultarVagas.Hide();
            txtRelatorios.Hide();
            txtPagamentos.Hide();
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

        private void btnConsultarVaga_Click(object sender, EventArgs e)
        {
            txtBemVindo.Hide();
            txtCadastroclt.Hide();
            txtConsultarVagas.Show();
            txtRelatorios.Hide();
            txtPagamentos.Hide();
            VagaView consultaVaga = new VagaView();
            consultaVaga.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(consultaVaga);
            consultaVaga.Dock = DockStyle.Fill;
            consultaVaga.Show();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            txtBemVindo.Hide();
            txtCadastroclt.Hide();
            txtConsultarVagas.Hide();
            txtRelatorios.Show();
            txtPagamentos.Hide();
            Relatorios relatorio = new Relatorios();
            relatorio.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(relatorio);
            relatorio.Dock = DockStyle.Fill;
            relatorio.Show();
        }

        private void btnPagamentos_Click(object sender, EventArgs e)
        {
            txtBemVindo.Hide();
            txtCadastroclt.Hide();
            txtConsultarVagas.Hide();
            txtRelatorios.Hide();
            txtPagamentos.Show();
            Pagamentos pagamento = new Pagamentos();
            pagamento.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(pagamento);
            pagamento.Dock = DockStyle.Fill;
            pagamento.Show();
        }
    }
}
