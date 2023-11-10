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
using System.Windows.Forms.VisualStyles;

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

        private void cbModoBusca_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbModoBusca.SelectedIndex == 0)
            {
                txtCodigoTransacao.Hide();
                btnBuscarCod.Hide();
                txtNome.Show();
                lblTraco.Show();
                btnBuscarNome.Show();
            }
            else if (cbModoBusca.SelectedIndex == 1)
            {
                lblTextoCod.Show();
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

        private void cbPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPagamento.SelectedIndex == 0)
            {
                AtivarCampos();
            }
            else if (cbPagamento.SelectedIndex == 1)
            {
                AtivarCampos();
                lblBanco.Hide();
                txtBanco.Hide();
            }
            else
            {
                return;
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
                    DialogResult result = MessageBox.Show("Deseja encerrar reserva?",
                        "Cliente localizado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        cbPagamento.Enabled = true;
                        valorTotal = pgcontrol.calcularValorReserva(ddCliente);
                        lblValorTotal.Text = "R$" + valorTotal.ToString() + ",00";
                    }
                    else
                    {
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Cliente não localizado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void btnBuscarCod_Click(object sender, EventArgs e)
        {
            if (txtCodigoTransacao.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Campo Codigo da transação inválido", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                int cod = Convert.ToInt32(txtCodigoTransacao.Text.Trim());

                ddCliente = rlControl.ObterDadosCliente_Cod(cod);
                if (ddCliente != null)
                {
                    DialogResult result = MessageBox.Show("Deseja encerrar reserva?",
                        "Cliente localizado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        cbPagamento.Enabled = true;
                        valorTotal = pgcontrol.calcularValorReserva(ddCliente);
                        lblValorTotal.Text = "R$" + valorTotal.ToString() + ",00";
                    }
                    else
                    {
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Cliente não localizado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            PagamentoController pgControl = new();


            if (cbPagamento.SelectedIndex == 0)
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
                    string formaPagamento = cbPagamento.SelectedItem.ToString().Trim();
                    MessageBox.Show("Pagamento Concluído!", "Transacao OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DesativarCampos();
                    Limpar();
                    ddPagamento = pgControl.CadastrarTransacao(valorTotal, cartao, formaPagamento);
                    rlControl.ComprovanteTransacao(ddCliente, ddPagamento);
                }

            }
            else if (cbPagamento.SelectedIndex == 1)
            {
                if (txtCartao.Text.Trim() == String.Empty || txtVencimento.Text.Trim() == String.Empty
                || txtCod.Text.Trim() == String.Empty)
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
                    string formaPagamento = cbPagamento.SelectedItem.ToString().Trim();
                    MessageBox.Show("Pagamento Concluído!", "Transacao OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ddPagamento = pgControl.CadastrarTransacao(valorTotal, cartao, formaPagamento);
                    rlControl.ComprovanteTransacao(ddCliente, ddPagamento);
                    Limpar();
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
            if (cbPagamento.SelectedIndex == 0 && e.KeyChar == 13)
            {
                txtCod.Focus();
            }
            else if (cbPagamento.SelectedIndex == 1 && e.KeyChar == 13)
            {
                btnPagar.Focus();
            }
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
            btnPagar.Enabled = true;
            txtBanco.Enabled = true;
            txtCod.Enabled = true;
            txtVencimento.Enabled = true;
            txtCartao.Enabled = true;
            cbPagamento.Enabled = true;
        }
        public void DesativarCampos()
        {
            lblTextoCod.Hide();
            txtCodigoTransacao.Hide();
            txtNome.Hide();
            lblTraco.Hide();
            btnPagar.Enabled = false;
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


    }
}
