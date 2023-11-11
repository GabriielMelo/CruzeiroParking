using PrototipoProjetoInterdisciplinar.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoProjetoInterdisciplinar.View
{
    public partial class RelatorioView : Form
    {
        RelatorioController rlControl = new();
        public RelatorioView()
        {
            InitializeComponent();
        }

        public void PreencherDataGridView(DataTable dataTable)
        {
            dataRelatorioClt.DataSource = dataTable;
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            if (cb.SelectedIndex == 0)
            {
                rlControl.RelatorioClientes(this);
            }
            else if (cb.SelectedIndex == 1)
            {

                rlControl.RelatoriosHistoricoClientes(this);

            } else if(cb.SelectedIndex == 2)
            {
                rlControl.RelatoriosFaturamentoMensal(this);
            }
        }
    }
}
