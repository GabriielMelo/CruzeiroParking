using Org.BouncyCastle.Crmf;
using PrototipoProjetoInterdisciplinar.Controller;
using PrototipoProjetoInterdisciplinar.Model;
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
        RelatorioModel ddCliente = new();
        PagamentoModel ddPagamento = new();
        RelatorioController rlControl = new();
        PagamentoController pgcontrol = new();
        double valorTotal;
        public PagamentoView()
        {
            InitializeComponent();
            DesativarCampos();
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

        public void AtivarCampos()
        {
            btnPagar.Show();
            txtBanco.Enabled = true;
            txtCod.Enabled = true;
            txtVencimento.Enabled = true;
            txtCartao.Enabled = true;
            cbPagamento.Enabled = true;
        }
        public void DesativarCampos()
        {
            txtCodigoTransacao.Hide();
            txtNome.Hide();
            lblTraco.Hide();
            btnPagar.Hide();
            btnBuscarNome.Hide();
            btnBuscarCod.Hide();
            txtBanco.Enabled = false;
            txtCod.Enabled = false;
            txtVencimento.Enabled = false;
            txtCartao.Enabled = false;
            cbPagamento.Enabled = false;
            cbModoBusca.SelectedIndex = 0;
            cbPagamento.SelectedIndex = 0;
        }

        private void cbModoBusca_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbModoBusca.SelectedIndex == 1)
            {
                txtCodigoTransacao.Hide();
                btnBuscarCod.Hide();
                txtNome.Show();
                lblTraco.Show();
                btnBuscarNome.Show();
            }
            else if (cbModoBusca.SelectedIndex == 2)
            {
                btnBuscarNome.Hide();
                txtNome.Hide();
                txtCodigoTransacao.Show();
                lblTraco.Show();
                btnBuscarCod.Show();

            }
            else
            {
                DesativarCampos();
            }
        }

        private void btnBuscarNome_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Campo Nome inválido", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string nome = txtNome.Text.Trim();

                ddCliente = rlControl.ObterDadosCliente_Nome(nome);
                if (ddCliente != null)
                {

                    valorTotal = pgcontrol.calcularValorReserva(ddCliente);
                    MessageBox.Show("O valor total é de : " + valorTotal);
                    lblValorTotal.Text = valorTotal.ToString();
                }
                else
                {
                    MessageBox.Show("Cliente não localizado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void txtCartao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtCartao.Text.Trim().Length != 16 || !txtCartao.Text.Trim().All(char.IsDigit))
                {
                    MessageBox.Show("Atenção ao digitar os dados do Cartão", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCartao.Focus();
                    return;
                }
                txtVencimento.Focus();
            }
        }

        private void txtVencimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbPagamento.SelectedIndex == 1 && e.KeyChar == 13)
            {
                txtCod.Focus();
            }
            else if (cbPagamento.SelectedIndex == 2 && e.KeyChar == 13)
            {
                btnPagar.Focus();
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            PagamentoController pgControl = new();


            if (cbPagamento.SelectedIndex == 1)
            {
                if (txtCartao.Text.Trim() == String.Empty || txtVencimento.Text.Trim() == String.Empty
                || txtCod.Text.Trim() == String.Empty || txtBanco.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Favor preencher todos os dados para o pagamento"
                    , "Falha na transação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!txtCartao.Text.Trim().All(char.IsDigit))
                {
                    MessageBox.Show("Atenção ao digitar os dados do Cartão", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCartao.Focus();
                    return;
                }
                else
                {
                    string cartao = txtCartao.Text.Trim();
                    string ocultarCartao = cartao.Substring(cartao.Length - 4);
                    cartao = "xxxx-xxxx-xxxx-" + ocultarCartao;
                    MessageBox.Show("Pagamento Concluído!", "Transacao OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ddPagamento = pgControl.CadastrarTransacao(valorTotal, cartao);
                    rlControl.ComprovanteTransacao(ddCliente, ddPagamento);
                    Limpar();

                }

            }
            else if (cbPagamento.SelectedIndex == 2)
            {
                if (txtCartao.Text.Trim() == String.Empty || txtVencimento.Text.Trim() == String.Empty
                || txtCod.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Favor preencher todos os dados para o pagamento"
                    , "Falha na transação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                else
                {


                }
            }

        }
    }
}
