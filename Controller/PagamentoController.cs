using MySql.Data.MySqlClient;
using PrototipoProjetoInterdisciplinar.Controllers;
using PrototipoProjetoInterdisciplinar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoProjetoInterdisciplinar.Controller
{
    public class PagamentoController
    {
        ConexaoBDController conn = new();

        public double calcularValorReserva(RelatorioModel dadosCliente )
        {
            
            try
            {
                conn.Conectar();

                string sql = "UPDATE transacoes SET valor = @valor WHERE cod_transacao = @cod_transacao";

                DateTime data = new();
                DateTime dataReserva = new();
                double valorPagamento;
                dataReserva = DateTime.ParseExact(dadosCliente.DataTransacao, "yyyy/MM/dd HH", null);
                double horaAtual = data.Hour;
                double horaReserva = dataReserva.Hour;
                valorPagamento = (horaReserva - horaAtual) * 8.0;

                MySqlCommand command = new(sql, conn.ObterConexao());

                command.Parameters.AddWithValue("@valor", valorPagamento);
                command.Parameters.AddWithValue("@cod_transacao", dadosCliente.Cod_transacao);

                command.ExecuteNonQuery();

                return valorPagamento;

            } catch (FormatException ex)
            {
                MessageBox.Show("Erro ao recuperar a data", ex.Message);
                return 0.0;
            } finally
            {
                conn.FecharConexao();
            }
            
        }

        public PagamentoModel CadastrarTransacao(double valorTransacao,string cartao)
        {
            int cod_transacao = GerarCodTransacao();

            PagamentoModel dadosTransacao = new()
            {
                Autorizado = true,
                Descricao = "Pagamento realizado com Sucesso!",
                ValorTotal = valorTransacao,
                Cartao = cartao,
                Cod_transacaoPagamento = cod_transacao
            };

            return dadosTransacao;
        }


        public int GerarCodTransacao()
        {
            Random random = new();
            int cod = random.Next(10000000, 99999999);
            return cod;
        }


    }
}
