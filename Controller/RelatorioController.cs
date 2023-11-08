using MySql.Data.MySqlClient;
using PrototipoProjetoInterdisciplinar.Controllers;
using PrototipoProjetoInterdisciplinar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoProjetoInterdisciplinar.Controller
{
    public class RelatorioController
    {


        ConexaoBDModel conn = new();


        public RelatorioModel DadosCliente(int idCliente)
        {
            try
            {
                conn.Conectar();

                
                string sqlCliente = "SELECT * FROM clientes WHERE ID = @id";
                MySqlCommand commandCliente = new MySqlCommand(sqlCliente, conn.ObterConexao());
                commandCliente.Parameters.AddWithValue("@id", idCliente);
                MySqlDataReader readerCliente = commandCliente.ExecuteReader();

                RelatorioModel dadosCliente = new RelatorioModel();

                if (readerCliente.Read())
                {
                    dadosCliente.Nome = readerCliente["nome"].ToString();
                    dadosCliente.Endereco = readerCliente["endereco"].ToString();
                    dadosCliente.Telefone = readerCliente["telefone"].ToString();
                    dadosCliente.Documento = readerCliente["documento"].ToString();
                    dadosCliente.ModeloCarro = readerCliente["modeloCarro"].ToString();
                    dadosCliente.PlacaCarro = readerCliente["placaCarro"].ToString();
                }

                readerCliente.Close(); 

                
                string sqlTransacao = "SELECT * FROM transacoes WHERE ID_CLIENTE = @id";
                MySqlCommand commandTransacao = new MySqlCommand(sqlTransacao, conn.ObterConexao());
                commandTransacao.Parameters.AddWithValue("@id", idCliente);
                MySqlDataReader readerTransacao = commandTransacao.ExecuteReader();

                if (readerTransacao.Read())
                {
                    dadosCliente.DataTransacao = readerTransacao["data_transacao"].ToString();
                    dadosCliente.Cod_transacao = readerTransacao["cod_transacao"].ToString();
                    dadosCliente.Descricao = readerTransacao["descricao"].ToString();
                }

                return dadosCliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar a base de dados", ex.Message);
                return null;
            }
            finally
            {
                conn.FecharConexao();
            }
        }





    }
}
