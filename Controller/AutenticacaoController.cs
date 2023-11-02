using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoProjetoInterdisciplinar.Controllers
{
    public class AutenticacaoController
    {

        public bool validarUsuario(AutenticacaoModel autenticacao)
        {
            ConexaoBDModel conn = new ConexaoBDModel();
                try
                {
                    conn.Conectar();
                    MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM Funcionarios WHERE usuario = " +
                        "@usuario AND senha = @senha", conn.ObterConexao());
                    command.Parameters.AddWithValue("@usuario", autenticacao.Usuario);
                    command.Parameters.AddWithValue("@senha", autenticacao.Senha);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count == 1)
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
                    MessageBox.Show("Erro ao validar credenciais", ex.Message);
                    return false;
                }
                finally
                {
                    conn.FecharConexao();
                }

            }
        }

    }

