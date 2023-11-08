using MySql.Data.MySqlClient;
using PrototipoProjetoInterdisciplinar.Controller;
using PrototipoProjetoInterdisciplinar.Controllers;
using PrototipoProjetoInterdisciplinar.Model;
using PrototipoProjetoInterdisciplinar.Views;
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
    public partial class VagaView : Form
    {

        public VagaView()
        {
            InitializeComponent();
            VagaController vagas = new VagaController(this);
            vagas.ConsultarVagasDisponiveis();
            vagas.AtualizarInterfaceButtons();

        }


        private void vaga1_Click(object sender, EventArgs e)
        {
            CadastroClienteController cdCliente = new();
            TransacaoController transacao = new();
            TransacaoModel dadosTransacao = new();
            VagaController vagas = new VagaController(this);
            ClienteModel cliente = new();
            DialogResult result = MessageBox.Show("Cliente possui Cadastro?", "Confirmação",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string nomeCadastrado = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do cliente:", "Nome do Cliente");
                if (!string.IsNullOrEmpty(nomeCadastrado))
                {
                    cliente = cdCliente.BuscarClientePorNome(nomeCadastrado);

                    if (cliente != null)
                    {
                        
                        transacao.EfetuarTransacao(cliente);
                        bool vagaok = vagas.ConfirmarReserva(1);
                        if (vagaok)
                        {
                            vagas.AtualizarInterfaceButtons();
                            vaga1.BackColor = Color.Red;
                            vaga1.Enabled = false;
                            transacao.GerarComprovante(cliente, dadosTransacao);
                        }
                        else
                        {
                            vagas.AtualizarInterfaceButtons();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente não localizado", "Erro");
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não localizado", "Erro");
                }
            }
            else
            {
                MessageBox.Show("Efetue o cadastro do cliente para prosseguir", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void vaga2_Click(object sender, EventArgs e)
        {
            CadastroClienteController cdCliente = new();
            TransacaoController transacao = new();
            TransacaoModel dadosTransacao = new();
            VagaController vagas = new VagaController(this);
            ClienteModel cliente = new();
            DialogResult result = MessageBox.Show("Cliente possui Cadastro?", "Confirmação",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string nomeCadastrado = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do cliente:", "Nome do Cliente");
                if (!string.IsNullOrEmpty(nomeCadastrado))
                {
                    cliente = cdCliente.BuscarClientePorNome(nomeCadastrado);

                    if (cliente != null)
                    {

                        transacao.EfetuarTransacao(cliente);
                        bool vagaok = vagas.ConfirmarReserva(2);
                        if (vagaok)
                        {
                            vagas.AtualizarInterfaceButtons();
                            vaga2.BackColor = Color.Red;
                            vaga2.Enabled = false;
                            transacao.GerarComprovante(cliente, dadosTransacao);
                        }
                        else
                        {
                            vagas.AtualizarInterfaceButtons();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente não localizado", "Erro");
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não localizado", "Erro");
                }
            }
            else
            {
                MessageBox.Show("Efetue o cadastro do cliente para prosseguir", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void vaga3_Click(object sender, EventArgs e)
        {
            CadastroClienteController cdCliente = new();
            TransacaoController transacao = new();
            TransacaoModel dadosTransacao = new();
            VagaController vagas = new VagaController(this);
            ClienteModel cliente = new();
            DialogResult result = MessageBox.Show("Cliente possui Cadastro?", "Confirmação",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string nomeCadastrado = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do cliente:", "Nome do Cliente");
                if (!string.IsNullOrEmpty(nomeCadastrado))
                {
                    cliente = cdCliente.BuscarClientePorNome(nomeCadastrado);

                    if (cliente != null)
                    {

                        transacao.EfetuarTransacao(cliente);
                        bool vagaok = vagas.ConfirmarReserva(3);
                        if (vagaok)
                        {
                            vagas.AtualizarInterfaceButtons();
                            vaga3.BackColor = Color.Red;
                            vaga3.Enabled = false;
                            transacao.GerarComprovante(cliente, dadosTransacao);
                        }
                        else
                        {
                            vagas.AtualizarInterfaceButtons();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente não localizado", "Erro");
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não localizado", "Erro");
                }
            }
            else
            {
                MessageBox.Show("Efetue o cadastro do cliente para prosseguir", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void vaga4_Click(object sender, EventArgs e)
        {
            CadastroClienteController cdCliente = new();
            TransacaoController transacao = new();
            TransacaoModel dadosTransacao = new();
            VagaController vagas = new VagaController(this);
            ClienteModel cliente = new();
            DialogResult result = MessageBox.Show("Cliente possui Cadastro?", "Confirmação",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string nomeCadastrado = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do cliente:", "Nome do Cliente");
                if (!string.IsNullOrEmpty(nomeCadastrado))
                {
                    cliente = cdCliente.BuscarClientePorNome(nomeCadastrado);

                    if (cliente != null)
                    {

                        transacao.EfetuarTransacao(cliente);
                        bool vagaok = vagas.ConfirmarReserva(4);
                        if (vagaok)
                        {
                            vagas.AtualizarInterfaceButtons();
                            vaga4.BackColor = Color.Red;
                            vaga4.Enabled = false;
                            transacao.GerarComprovante(cliente, dadosTransacao);
                        }
                        else
                        {
                            vagas.AtualizarInterfaceButtons();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente não localizado", "Erro");
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não localizado", "Erro");
                }
            }
            else
            {
                MessageBox.Show("Efetue o cadastro do cliente para prosseguir", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void vaga5_Click(object sender, EventArgs e)
        {
            CadastroClienteController cdCliente = new();
            TransacaoController transacao = new();
            TransacaoModel dadosTransacao = new();
            VagaController vagas = new VagaController(this);
            ClienteModel cliente = new();
            DialogResult result = MessageBox.Show("Cliente possui Cadastro?", "Confirmação",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string nomeCadastrado = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do cliente:", "Nome do Cliente");
                if (!string.IsNullOrEmpty(nomeCadastrado))
                {
                    cliente = cdCliente.BuscarClientePorNome(nomeCadastrado);

                    if (cliente != null)
                    {

                        transacao.EfetuarTransacao(cliente);
                        bool vagaok = vagas.ConfirmarReserva(5);
                        if (vagaok)
                        {
                            vagas.AtualizarInterfaceButtons();
                            vaga5.BackColor = Color.Red;
                            vaga5.Enabled = false;
                            transacao.GerarComprovante(cliente, dadosTransacao);
                        }
                        else
                        {
                            vagas.AtualizarInterfaceButtons();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente não localizado", "Erro");
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não localizado", "Erro");
                }
            }
            else
            {
                MessageBox.Show("Efetue o cadastro do cliente para prosseguir", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void vaga6_Click(object sender, EventArgs e)
        {
            CadastroClienteController cdCliente = new();
            TransacaoController transacao = new();
            TransacaoModel dadosTransacao = new();
            VagaController vagas = new VagaController(this);
            ClienteModel cliente = new();
            DialogResult result = MessageBox.Show("Cliente possui Cadastro?", "Confirmação",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string nomeCadastrado = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do cliente:", "Nome do Cliente");
                if (!string.IsNullOrEmpty(nomeCadastrado))
                {
                    cliente = cdCliente.BuscarClientePorNome(nomeCadastrado);

                    if (cliente != null)
                    {

                        transacao.EfetuarTransacao(cliente);
                        bool vagaok = vagas.ConfirmarReserva(6);
                        if (vagaok)
                        {
                            vagas.AtualizarInterfaceButtons();
                            vaga6.BackColor = Color.Red;
                            vaga6.Enabled = false;
                            transacao.GerarComprovante(cliente, dadosTransacao);
                        }
                        else
                        {
                            vagas.AtualizarInterfaceButtons();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente não localizado", "Erro");
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não localizado", "Erro");
                }
            }
            else
            {
                MessageBox.Show("Efetue o cadastro do cliente para prosseguir", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void vaga7_Click(object sender, EventArgs e)
        {
            CadastroClienteController cdCliente = new();
            TransacaoController transacao = new();
            TransacaoModel dadosTransacao = new();
            VagaController vagas = new VagaController(this);
            ClienteModel cliente = new();
            DialogResult result = MessageBox.Show("Cliente possui Cadastro?", "Confirmação",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string nomeCadastrado = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do cliente:", "Nome do Cliente");
                if (!string.IsNullOrEmpty(nomeCadastrado))
                {
                    cliente = cdCliente.BuscarClientePorNome(nomeCadastrado);

                    if (cliente != null)
                    {

                        transacao.EfetuarTransacao(cliente);
                        bool vagaok = vagas.ConfirmarReserva(7);
                        if (vagaok)
                        {
                            vagas.AtualizarInterfaceButtons();
                            vaga7.BackColor = Color.Red;
                            vaga7.Enabled = false;
                            transacao.GerarComprovante(cliente, dadosTransacao);
                        }
                        else
                        {
                            vagas.AtualizarInterfaceButtons();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente não localizado", "Erro");
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não localizado", "Erro");
                }
            }
            else
            {
                MessageBox.Show("Efetue o cadastro do cliente para prosseguir", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void vaga8_Click(object sender, EventArgs e)
        {
            CadastroClienteController cdCliente = new();
            TransacaoController transacao = new();
            TransacaoModel dadosTransacao = new();
            VagaController vagas = new VagaController(this);
            ClienteModel cliente = new();
            DialogResult result = MessageBox.Show("Cliente possui Cadastro?", "Confirmação",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string nomeCadastrado = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do cliente:", "Nome do Cliente");
                if (!string.IsNullOrEmpty(nomeCadastrado))
                {
                    cliente = cdCliente.BuscarClientePorNome(nomeCadastrado);

                    if (cliente != null)
                    {

                        transacao.EfetuarTransacao(cliente);
                        bool vagaok = vagas.ConfirmarReserva(8);
                        if (vagaok)
                        {
                            vagas.AtualizarInterfaceButtons();
                            vaga8.BackColor = Color.Red;
                            vaga8.Enabled = false;
                            transacao.GerarComprovante(cliente, dadosTransacao);
                        }
                        else
                        {
                            vagas.AtualizarInterfaceButtons();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente não localizado", "Erro");
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não localizado", "Erro");
                }
            }
            else
            {
                MessageBox.Show("Efetue o cadastro do cliente para prosseguir", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void vaga9_Click(object sender, EventArgs e)
        {
            CadastroClienteController cdCliente = new();
            TransacaoController transacao = new();
            TransacaoModel dadosTransacao = new();
            VagaController vagas = new VagaController(this);
            ClienteModel cliente = new();
            DialogResult result = MessageBox.Show("Cliente possui Cadastro?", "Confirmação",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string nomeCadastrado = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do cliente:", "Nome do Cliente");
                if (!string.IsNullOrEmpty(nomeCadastrado))
                {
                    cliente = cdCliente.BuscarClientePorNome(nomeCadastrado);

                    if (cliente != null)
                    {

                        transacao.EfetuarTransacao(cliente);
                        bool vagaok = vagas.ConfirmarReserva(9);
                        if (vagaok)
                        {
                            vagas.AtualizarInterfaceButtons();
                            vaga9.BackColor = Color.Red;
                            vaga9.Enabled = false;
                            transacao.GerarComprovante(cliente, dadosTransacao);
                        }
                        else
                        {
                            vagas.AtualizarInterfaceButtons();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente não localizado", "Erro");
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não localizado", "Erro");
                }
            }
            else
            {
                MessageBox.Show("Efetue o cadastro do cliente para prosseguir", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void vaga10_Click(object sender, EventArgs e)
        {
            CadastroClienteController cdCliente = new();
            TransacaoController transacao = new();
            TransacaoModel dadosTransacao = new();
            VagaController vagas = new VagaController(this);
            ClienteModel cliente = new();
            DialogResult result = MessageBox.Show("Cliente possui Cadastro?", "Confirmação",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string nomeCadastrado = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do cliente:", "Nome do Cliente");
                if (!string.IsNullOrEmpty(nomeCadastrado))
                {
                    cliente = cdCliente.BuscarClientePorNome(nomeCadastrado);

                    if (cliente != null)
                    {

                        transacao.EfetuarTransacao(cliente);
                        bool vagaok = vagas.ConfirmarReserva(10);
                        if (vagaok)
                        {
                            vagas.AtualizarInterfaceButtons();
                            vaga10.BackColor = Color.Red;
                            vaga10.Enabled = false;
                            transacao.GerarComprovante(cliente, dadosTransacao);
                        }
                        else
                        {
                            vagas.AtualizarInterfaceButtons();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente não localizado", "Erro");
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não localizado", "Erro");
                }
            }
            else
            {
                MessageBox.Show("Efetue o cadastro do cliente para prosseguir", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void vaga11_Click(object sender, EventArgs e)
        {
            CadastroClienteController cdCliente = new();
            TransacaoController transacao = new();
            TransacaoModel dadosTransacao = new();
            VagaController vagas = new VagaController(this);
            ClienteModel cliente = new();
            DialogResult result = MessageBox.Show("Cliente possui Cadastro?", "Confirmação",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string nomeCadastrado = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do cliente:", "Nome do Cliente");
                if (!string.IsNullOrEmpty(nomeCadastrado))
                {
                    cliente = cdCliente.BuscarClientePorNome(nomeCadastrado);

                    if (cliente != null)
                    {

                        transacao.EfetuarTransacao(cliente);
                        bool vagaok = vagas.ConfirmarReserva(11);
                        if (vagaok)
                        {
                            vagas.AtualizarInterfaceButtons();
                            vaga11.BackColor = Color.Red;
                            vaga11.Enabled = false;
                            transacao.GerarComprovante(cliente, dadosTransacao);
                        }
                        else
                        {
                            vagas.AtualizarInterfaceButtons();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente não localizado", "Erro");
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não localizado", "Erro");
                }
            }
            else
            {
                MessageBox.Show("Efetue o cadastro do cliente para prosseguir", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void vaga12_Click(object sender, EventArgs e)
        {
            CadastroClienteController cdCliente = new();
            TransacaoController transacao = new();
            TransacaoModel dadosTransacao = new();
            VagaController vagas = new VagaController(this);
            ClienteModel cliente = new();
            DialogResult result = MessageBox.Show("Cliente possui Cadastro?", "Confirmação",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string nomeCadastrado = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do cliente:", "Nome do Cliente");
                if (!string.IsNullOrEmpty(nomeCadastrado))
                {
                    cliente = cdCliente.BuscarClientePorNome(nomeCadastrado);

                    if (cliente != null)
                    {

                        transacao.EfetuarTransacao(cliente);
                        bool vagaok = vagas.ConfirmarReserva(12);
                        if (vagaok)
                        {
                            vagas.AtualizarInterfaceButtons();
                            vaga12.BackColor = Color.Red;
                            vaga12.Enabled = false;
                            transacao.GerarComprovante(cliente, dadosTransacao);
                        }
                        else
                        {
                            vagas.AtualizarInterfaceButtons();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente não localizado", "Erro");
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não localizado", "Erro");
                }
            }
            else
            {
                MessageBox.Show("Efetue o cadastro do cliente para prosseguir", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void vaga13_Click(object sender, EventArgs e)
        {
            CadastroClienteController cdCliente = new();
            TransacaoController transacao = new();
            TransacaoModel dadosTransacao = new();
            VagaController vagas = new VagaController(this);
            ClienteModel cliente = new();
            DialogResult result = MessageBox.Show("Cliente possui Cadastro?", "Confirmação",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string nomeCadastrado = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do cliente:", "Nome do Cliente");
                if (!string.IsNullOrEmpty(nomeCadastrado))
                {
                    cliente = cdCliente.BuscarClientePorNome(nomeCadastrado);

                    if (cliente != null)
                    {

                        transacao.EfetuarTransacao(cliente);
                        bool vagaok = vagas.ConfirmarReserva(13);
                        if (vagaok)
                        {
                            vagas.AtualizarInterfaceButtons();
                            vaga13.BackColor = Color.Red;
                            vaga13.Enabled = false;
                            transacao.GerarComprovante(cliente, dadosTransacao);
                        }
                        else
                        {
                            vagas.AtualizarInterfaceButtons();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente não localizado", "Erro");
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não localizado", "Erro");
                }
            }
            else
            {
                MessageBox.Show("Efetue o cadastro do cliente para prosseguir", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void vaga14_Click(object sender, EventArgs e)
        {
            CadastroClienteController cdCliente = new();
            TransacaoController transacao = new();
            TransacaoModel dadosTransacao = new();
            VagaController vagas = new VagaController(this);
            ClienteModel cliente = new();
            DialogResult result = MessageBox.Show("Cliente possui Cadastro?", "Confirmação",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string nomeCadastrado = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do cliente:", "Nome do Cliente");
                if (!string.IsNullOrEmpty(nomeCadastrado))
                {
                    cliente = cdCliente.BuscarClientePorNome(nomeCadastrado);

                    if (cliente != null)
                    {

                        transacao.EfetuarTransacao(cliente);
                        bool vagaok = vagas.ConfirmarReserva(14);
                        if (vagaok)
                        {
                            vagas.AtualizarInterfaceButtons();
                            vaga14.BackColor = Color.Red;
                            vaga14.Enabled = false;
                            transacao.GerarComprovante(cliente, dadosTransacao);
                        }
                        else
                        {
                            vagas.AtualizarInterfaceButtons();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente não localizado", "Erro");
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não localizado", "Erro");
                }
            }
            else
            {
                MessageBox.Show("Efetue o cadastro do cliente para prosseguir", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void vaga15_Click(object sender, EventArgs e)
        {
            CadastroClienteController cdCliente = new();
            TransacaoController transacao = new();
            TransacaoModel dadosTransacao = new();
            VagaController vagas = new VagaController(this);
            ClienteModel cliente = new();
            DialogResult result = MessageBox.Show("Cliente possui Cadastro?", "Confirmação",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string nomeCadastrado = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do cliente:", "Nome do Cliente");
                if (!string.IsNullOrEmpty(nomeCadastrado))
                {
                    cliente = cdCliente.BuscarClientePorNome(nomeCadastrado);

                    if (cliente != null)
                    {

                        transacao.EfetuarTransacao(cliente);
                        bool vagaok = vagas.ConfirmarReserva(15);
                        if (vagaok)
                        {
                            vagas.AtualizarInterfaceButtons();
                            vaga15.BackColor = Color.Red;
                            vaga15.Enabled = false;
                            transacao.GerarComprovante(cliente, dadosTransacao);
                        }
                        else
                        {
                            vagas.AtualizarInterfaceButtons();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente não localizado", "Erro");
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não localizado", "Erro");
                }
            }
            else
            {
                MessageBox.Show("Efetue o cadastro do cliente para prosseguir", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void vaga16_Click(object sender, EventArgs e)
        {
            CadastroClienteController cdCliente = new();
            TransacaoController transacao = new();
            TransacaoModel dadosTransacao = new();
            VagaController vagas = new VagaController(this);
            ClienteModel cliente = new();
            DialogResult result = MessageBox.Show("Cliente possui Cadastro?", "Confirmação",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string nomeCadastrado = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do cliente:", "Nome do Cliente");
                if (!string.IsNullOrEmpty(nomeCadastrado))
                {
                    cliente = cdCliente.BuscarClientePorNome(nomeCadastrado);

                    if (cliente != null)
                    {

                        transacao.EfetuarTransacao(cliente);
                        bool vagaok = vagas.ConfirmarReserva(16);
                        if (vagaok)
                        {
                            vagas.AtualizarInterfaceButtons();
                            vaga16.BackColor = Color.Red;
                            vaga16.Enabled = false;
                            transacao.GerarComprovante(cliente, dadosTransacao);
                        }
                        else
                        {
                            vagas.AtualizarInterfaceButtons();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente não localizado", "Erro");
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não localizado", "Erro");
                }
            }
            else
            {
                MessageBox.Show("Efetue o cadastro do cliente para prosseguir", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void vaga17_Click(object sender, EventArgs e)
        {
            CadastroClienteController cdCliente = new();
            TransacaoController transacao = new();
            TransacaoModel dadosTransacao = new();
            VagaController vagas = new VagaController(this);
            ClienteModel cliente = new();
            DialogResult result = MessageBox.Show("Cliente possui Cadastro?", "Confirmação",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string nomeCadastrado = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do cliente:", "Nome do Cliente");
                if (!string.IsNullOrEmpty(nomeCadastrado))
                {
                    cliente = cdCliente.BuscarClientePorNome(nomeCadastrado);

                    if (cliente != null)
                    {

                        transacao.EfetuarTransacao(cliente);
                        bool vagaok = vagas.ConfirmarReserva(17);
                        if (vagaok)
                        {
                            vagas.AtualizarInterfaceButtons();
                            vaga17.BackColor = Color.Red;
                            vaga17.Enabled = false;
                            transacao.GerarComprovante(cliente, dadosTransacao);
                        }
                        else
                        {
                            vagas.AtualizarInterfaceButtons();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente não localizado", "Erro");
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não localizado", "Erro");
                }
            }
            else
            {
                MessageBox.Show("Efetue o cadastro do cliente para prosseguir", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void vaga18_Click(object sender, EventArgs e)
        {
            CadastroClienteController cdCliente = new();
            TransacaoController transacao = new();
            TransacaoModel dadosTransacao = new();
            VagaController vagas = new VagaController(this);
            ClienteModel cliente = new();
            DialogResult result = MessageBox.Show("Cliente possui Cadastro?", "Confirmação",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string nomeCadastrado = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do cliente:", "Nome do Cliente");
                if (!string.IsNullOrEmpty(nomeCadastrado))
                {
                    cliente = cdCliente.BuscarClientePorNome(nomeCadastrado);

                    if (cliente != null)
                    {

                        transacao.EfetuarTransacao(cliente);
                        bool vagaok = vagas.ConfirmarReserva(18);
                        if (vagaok)
                        {
                            vagas.AtualizarInterfaceButtons();
                            vaga18.BackColor = Color.Red;
                            vaga18.Enabled = false;
                            transacao.GerarComprovante(cliente, dadosTransacao);
                        }
                        else
                        {
                            vagas.AtualizarInterfaceButtons();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente não localizado", "Erro");
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não localizado", "Erro");
                }
            }
            else
            {
                MessageBox.Show("Efetue o cadastro do cliente para prosseguir", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void vaga19_Click(object sender, EventArgs e)
        {
            CadastroClienteController cdCliente = new();
            TransacaoController transacao = new();
            TransacaoModel dadosTransacao = new();
            VagaController vagas = new VagaController(this);
            ClienteModel cliente = new();
            DialogResult result = MessageBox.Show("Cliente possui Cadastro?", "Confirmação",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string nomeCadastrado = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do cliente:", "Nome do Cliente");
                if (!string.IsNullOrEmpty(nomeCadastrado))
                {
                    cliente = cdCliente.BuscarClientePorNome(nomeCadastrado);

                    if (cliente != null)
                    {

                        transacao.EfetuarTransacao(cliente);
                        bool vagaok = vagas.ConfirmarReserva(19);
                        if (vagaok)
                        {
                            vagas.AtualizarInterfaceButtons();
                            vaga19.BackColor = Color.Red;
                            vaga19.Enabled = false;
                            transacao.GerarComprovante(cliente, dadosTransacao);
                        }
                        else
                        {
                            vagas.AtualizarInterfaceButtons();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente não localizado", "Erro");
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não localizado", "Erro");
                }
            }
            else
            {
                MessageBox.Show("Efetue o cadastro do cliente para prosseguir", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void vaga20_Click(object sender, EventArgs e)
        {
            CadastroClienteController cdCliente = new();
            TransacaoController transacao = new();
            TransacaoModel dadosTransacao = new();
            VagaController vagas = new VagaController(this);
            ClienteModel cliente = new();
            DialogResult result = MessageBox.Show("Cliente possui Cadastro?", "Confirmação",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string nomeCadastrado = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do cliente:", "Nome do Cliente");
                if (!string.IsNullOrEmpty(nomeCadastrado))
                {
                    cliente = cdCliente.BuscarClientePorNome(nomeCadastrado);

                    if (cliente != null)
                    {

                        transacao.EfetuarTransacao(cliente);
                        bool vagaok = vagas.ConfirmarReserva(20);
                        if (vagaok)
                        {
                            vagas.AtualizarInterfaceButtons();
                            vaga20.BackColor = Color.Red;
                            vaga20.Enabled = false;
                            transacao.GerarComprovante(cliente, dadosTransacao);
                        }
                        else
                        {
                            vagas.AtualizarInterfaceButtons();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente não localizado", "Erro");
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não localizado", "Erro");
                }
            }
            else
            {
                MessageBox.Show("Efetue o cadastro do cliente para prosseguir", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }

}

