using MySql.Data.MySqlClient;
using PrototipoProjetoInterdisciplinar.Controllers;
using PrototipoProjetoInterdisciplinar.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoProjetoInterdisciplinar.Controller
{
    public class VagaController
    {
        private VagaModel vagaModel;

        public VagaController()
        {
            vagaModel = new VagaModel();
        }

        public void AtualizarVagasDisponiveis()
        {
            ConexaoBDModel conn = new ConexaoBDModel();
            conn.Conectar();

            string sql = "SELECT disponivel FROM Vagas";

            using (MySqlConnection connection = conn.ObterConexao())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            vagaModel.DisponibilidadeVagas.Add(reader.GetBoolean(0));
                        }
                    }
                }
            }

            conn.FecharConexao();
        }

        public VagaModel ObterVagaModel()
        {
            return vagaModel;
        }

    }
}
