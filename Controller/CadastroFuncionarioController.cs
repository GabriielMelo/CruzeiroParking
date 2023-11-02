using MySql.Data.MySqlClient;
using PrototipoProjetoInterdisciplinar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoProjetoInterdisciplinar.Controllers
{
    public class CadastroFuncionarioController
    {

        ConexaoBDModel conn = new ConexaoBDModel();

        public bool cadastroFuncionario(FuncionarioModel funcionario)
        {

            try
            {
                conn.Conectar();
                string sql = "INSERT INTO funcionario (nome,usuario,senha) VALUES (@nome,@usuario,@senha)";

                MySqlCommand command = new MySqlCommand(sql, conn.ObterConexao());

                command.Parameters.AddWithValue("@nome", funcionario.Nome);
                command.Parameters.AddWithValue("@usuario", funcionario.Usuario);
                command.Parameters.AddWithValue("@senha", funcionario.Senha);

                int count = command.ExecuteNonQuery();

                if (count > 0)  
                {
                    MessageBox.Show("Funcionario Cadastrado com sucesso");
                    return true;

                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar o funcionario");
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar", ex.Message);
                return false;

            }
            finally
            {
                conn.FecharConexao();

            }


        }


    }
}
