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
    public partial class PagamentoView : Form
    {
        public PagamentoView()
        {
            InitializeComponent();

        }

        private void Limpar()
        {
            txtCartao.Clear();
            txtVencimento.Clear();
            txtCod.Clear();
            txtBanco.Clear();
            txtNome.Clear();
            txtCodigoTransacao.Clear();
        }


    }
}
