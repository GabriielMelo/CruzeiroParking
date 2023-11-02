using PrototipoProjetoInterdisciplinar.Controllers;
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

namespace PrototipoProjetoInterdisciplinar.Views
{
    public partial class CadastroFuncionarioView : Form
    {
        public CadastroFuncionarioView()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginView formLogin = new LoginView();
            formLogin.MdiParent = HomeView.ActiveForm;
            formLogin.Show();
        }

        public void Limpar()
        {
            txtNome.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
            txtSenhaConfirm.Clear();
        }

        public bool validarCampos()
        {
            if (txtSenha.Text.Trim() == txtSenhaConfirm.Text.Trim())
            {
                if (txtNome.Text != String.Empty || txtUsuario.Text != String.Empty || txtSenha.Text != String.Empty)
                {

                    return true;

                }

                return true;
            }

            else

            {
                return false;
            }
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (this.validarCampos())
            {

                FuncionarioModel funcionario = new FuncionarioModel();
                funcionario.definirDados(txtNome.Text.Trim(),txtUsuario.Text.Trim(),txtSenha.Text.Trim());

                CadastroFuncionarioController cdFuncionario = new CadastroFuncionarioController();
                bool cadastroOk = cdFuncionario.cadastroFuncionario(funcionario);
                if (cadastroOk)
                {
                    MessageBox.Show("Funcionario cadastrado com sucesso!", "Cadastro Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Limpar();
                } else
                {
                    MessageBox.Show("Erro ao cadastrar Funcionario!", "Cadastro Não Ok", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Limpar();
                    return;
                }

            } else
            {
                MessageBox.Show("Preencha todos os campos corretamente!", "Atenção!",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
