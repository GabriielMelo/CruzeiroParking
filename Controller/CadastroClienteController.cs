using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoProjetoInterdisciplinar.Controllers
{
    public class CadastroClienteController
    {
        ConexaoBDModel conn = new ConexaoBDModel();

        public bool cadastrarCliente(ClienteModel cliente)
        {
            try
            {
                conn.Conectar();
                string sql = "INSERT INTO clientes (nome,documento,endereco,modeloCarro,telefone,placaCarro) " +
                    "VALUES (@nome,@documento,@endereco,@modeloCarro,@telefone,@placaCarro)";

                MySqlCommand command = new MySqlCommand(sql,conn.ObterConexao());

                command.Parameters.AddWithValue("@nome", cliente.Nome);
                command.Parameters.AddWithValue("@documento", cliente.Documento);
                command.Parameters.AddWithValue("@endereco", cliente.Endereco);
                command.Parameters.AddWithValue("@modeloCarro", cliente.ModeloCarro);
                command.Parameters.AddWithValue("telefone", cliente.Telefone);
                command.Parameters.AddWithValue("@placaCarro", cliente.PlacaCarro);

                int count = command.ExecuteNonQuery();

                if(count>0)
                {
                    
                    return true;

                } else
                {
                    
                    return false;
                }


            } catch (Exception ex) {
                MessageBox.Show("Erro ao cadastrar Cliente!", ex.Message);
                return false;
            } 
            finally
            {
                conn.FecharConexao();
            }



        }
    }
}
