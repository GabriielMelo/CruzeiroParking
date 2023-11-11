using MySql.Data.MySqlClient;
using OfficeOpenXml;
using PrototipoProjetoInterdisciplinar.Controllers;
using PrototipoProjetoInterdisciplinar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrototipoProjetoInterdisciplinar.Controller
{
    public class TransacaoController
    {
        ConexaoBDController conn = new();
        public bool EfetuarTransacao(ClienteModel cliente)
        {
            try
            {
                conn.Conectar();
                Random random = new();
                int id_cliente = cliente.Id;
                int cod_transacao = GerarCodigoTransacao();

                TransacaoModel transacao = new()
                {
                    Id_Cliente = id_cliente,
                    Data_Transacao = DateTime.Now.ToString("yyyy-MM-dd HH"),
                    Valor = 0,
                    Descricao = "Transacao OK",
                    Cod_transacao = cod_transacao
                };


                string sql = "INSERT INTO transacoes (id_cliente, data_transacao,valor,descricao,cod_transacao) VALUES(@id_cliente,@data_transacao,@valor,@descricao,@cod_transacao)";
               
                MySqlCommand command = new(sql, conn.ObterConexao());
                command.Parameters.AddWithValue("id_cliente", transacao.Id_Cliente);
                command.Parameters.AddWithValue("data_transacao", transacao.Data_Transacao);
                command.Parameters.AddWithValue("valor", transacao.Valor);
                command.Parameters.AddWithValue("descricao", transacao.Descricao);
                command.Parameters.AddWithValue("cod_transacao", transacao.Cod_transacao);

                int count = command.ExecuteNonQuery();

                if (count > 0)
                {

                    return true;

                }
                else
                {

                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar Transação!", ex.Message);
                return false;
            } finally
            {
                conn.FecharConexao();
            }
            
        }

        public int GerarCodigoTransacao()
        {
            Random random = new();
            int cod_transacao = random.Next(1000, 10000);
            return cod_transacao;
        }

        
    }
}
