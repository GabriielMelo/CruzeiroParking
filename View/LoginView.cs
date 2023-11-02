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
    public partial class LoginView : Form
    {

        public LoginView()
        {
            InitializeComponent();
            txtUsuario.Focus();

        }

        private void linkCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
            CadastroFuncionarioView cdFuncionario = new CadastroFuncionarioView();
            cdFuncionario.MdiParent = HomeView.ActiveForm;
            cdFuncionario.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.validarCampos())
            {
                AutenticacaoModel autenticacao = new AutenticacaoModel();

                autenticacao.definirDados(txtUsuario.Text.Trim(), txtSenha.Text.Trim());  

                AutenticacaoController autenticar = new AutenticacaoController();
                bool autenticacaoOk = autenticar.validarUsuario(autenticacao);

                if (autenticacaoOk) {
                    MessageBox.Show("Conexão bem-sucedida!", "Acesso Autorizado!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    InicioView inicio = new InicioView();
                    inicio.MdiParent = HomeView.ActiveForm;
                    inicio.Show();

                } else
                {
                    MessageBox.Show("Erro ao validar credenciais", "Atenção", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Limpar();
                    txtUsuario.Focus();
                    return;
                   
                }


            }
            
        }
        public bool validarCampos()
        {
            if (txtUsuario.Text.Trim() == String.Empty || txtSenha.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Usuario ou senha não podem estar vazios", "Atencao!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Limpar()
        {
            txtUsuario.Clear();
            txtSenha.Clear();
        }

        private void txtUsuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin.Focus();
            }
        }
    }
}
