using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using PrototipoProjetoInterdisciplinar.Controller;
using PrototipoProjetoInterdisciplinar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace PrototipoProjetoInterdisciplinar.Controllers
{
    public class CadastroClienteController
    {
        ConexaoBDController conn = new();
    
        public bool CadastrarCliente(ClienteModel cliente)
        {
            try
            {
                conn.Conectar();
                string sql = "INSERT INTO clientes (nome,documento,endereco,modeloCarro,telefone,placaCarro) " +
                    "VALUES (@nome,@documento,@endereco,@modeloCarro,@telefone,@placaCarro)";

                MySqlCommand command = new(sql,conn.ObterConexao());

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


        public ClienteModel BuscarClientePorNome(string nome)
        {
            try
            {
                conn.Conectar();
                string sql = "SELECT * FROM clientes WHERE NOME LIKE @nome";

                MySqlCommand command = new MySqlCommand(sql, conn.ObterConexao());
                command.Parameters.AddWithValue("@nome", "%" + nome + "%");
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int idCliente = (int)reader["id"];
                    
                    ClienteModel cliente = new()
                    {
                        Id = idCliente,
                        Nome = reader["nome"].ToString(),
                        Documento = reader["documento"].ToString(),
                        Endereco = reader["endereco"].ToString(),
                        Telefone = reader["telefone"].ToString(),
                        ModeloCarro = reader["modeloCarro"].ToString(),
                        PlacaCarro = reader["placaCarro"].ToString()
                    };
                    return cliente;
                }
                
                return null; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar cliente: " + ex.Message);
                return null;
            }
            finally
            {
                conn.FecharConexao();
            }
        }


    }
}
