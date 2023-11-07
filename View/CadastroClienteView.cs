using PrototipoProjetoInterdisciplinar.Controllers;
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
    public partial class CadastroClienteView : Form
    {
        public CadastroClienteView()
        {
            InitializeComponent();
        }

        public void Limpar()
        {
            txtNome.Clear();
            txtDocumento.Clear();
            txtEndereco.Clear();
            txtTelefone.Clear();
            txtModeloCarro.Clear();
            txtPlacaCarro.Clear();
        }
        public bool ValidarCampos()
        {
            if (txtNome.Text.Trim() == String.Empty || txtDocumento.Text.Trim() == String.Empty ||
               txtEndereco.Text.Trim() == String.Empty || txtTelefone.Text.Trim() == String.Empty ||
               txtModeloCarro.Text.Trim() == String.Empty || txtPlacaCarro.Text.Trim() == String.Empty)
            {


                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnCadastroclt_Click(object sender, EventArgs e)
        {

            if (this.ValidarCampos())
            {

                ClienteModel cliente = new ClienteModel();

                cliente.definirDados(txtNome.Text.Trim(), txtDocumento.Text.Trim(), txtEndereco.Text.Trim(),
                txtTelefone.Text.Trim(), txtModeloCarro.Text.Trim(), txtPlacaCarro.Text.Trim());

                CadastroClienteController cdCliente = new CadastroClienteController();
                bool cadastroOK = cdCliente.CadastrarCliente(cliente);

                if (cadastroOK)
                {
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Cadastro Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Limpar();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Cliente!", "Cadastro Não Ok", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Limpar();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos corretamente!", "Atenção!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDocumento.Focus();
            }
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtEndereco.Focus();
            }
        }
        private void txtEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtTelefone.Focus();
            }
        }
        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtModeloCarro.Focus();
            }
        }

        private void txtModeloCarro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPlacaCarro.Focus();
            }
        }

        private void txtPlacaCarro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnCadastroclt.Focus();
            }
        }
    }
}
