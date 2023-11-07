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
    public class TransacaoController
    {
        ConexaoBDModel conn = new();
        public bool EfetuarTransacao(TransacaoModel transacao)
        {
            try
            {
                conn.Conectar();
                string sql = "INSERT INTO transacoes (id_cliente, data_transacao,valor,descricao) VALUES(@id_cliente,@data_transacao,@valor,@descricao)";
               
                MySqlCommand command = new(sql, conn.ObterConexao());
                command.Parameters.AddWithValue("id_cliente", transacao.Id_Cliente);
                command.Parameters.AddWithValue("data_transacao", transacao.Data_Transacao);
                command.Parameters.AddWithValue("valor", transacao.Valor);
                command.Parameters.AddWithValue("descricao", transacao.Descricao);

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
    }
}
