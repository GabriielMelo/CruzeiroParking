using MySql.Data.MySqlClient;
using PrototipoProjetoInterdisciplinar.Model;
using PrototipoProjetoInterdisciplinar.View;
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
        private VagaView vagaView;
        ConexaoBDController conn = new();
        public VagaController(VagaView view)
        {
            vagaModel = new VagaModel();
            vagaView = view; 
        }
        public VagaController() { }
       
        public void ConsultarVagasDisponiveis()
        {
            
            conn.Conectar();

            string sql = "SELECT disponivel FROM Vagas";

            using (MySqlConnection connection = conn.ObterConexao())
            {

                using MySqlCommand command = new(sql, connection);

                using MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    vagaModel.DisponibilidadeVagas.Add(reader.GetBoolean(0));
                }
            }

            conn.FecharConexao();
        }

        public bool ConfirmarReserva(int vagaID)
        {
            try { 

                conn.Conectar();
                string sql = "UPDATE Vagas SET disponivel = false WHERE id_vaga = @idVaga";
                MySqlCommand command = new(sql, conn.ObterConexao());
                command.Parameters.AddWithValue("@idVaga", vagaID);
                int atualizado = command.ExecuteNonQuery();

                if (atualizado > 0)
                {
                    MessageBox.Show("Vaga atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar a vaga!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return true;
            } catch(Exception ex)
            {
                MessageBox.Show("Erro ao atualizar a Vaga", ex.Message);
                return false;
            }
            finally
            {
                conn.FecharConexao(); 
            }

        }

        public int QuantidadeVagasDisponíveis()
        {
            int vagasDisponiveis = 0;

            try
            {
                conn.Conectar();

                string sql = "SELECT COUNT(*) FROM vagas WHERE disponivel = 1";
                MySqlCommand command = new MySqlCommand(sql, conn.ObterConexao());
                vagasDisponiveis = (int)(long)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.FecharConexao();
            }

            return vagasDisponiveis;
        }

        public void LiberarVaga(int id)
        {
            try
            {
                conn.Conectar();

                string sql = "update  vagas set disponivel = true where id_vaga=@id";

                MySqlCommand command = new(sql, conn.ObterConexao());

                command.Parameters.AddWithValue("@id", id);
                
                command.ExecuteNonQuery();

                MessageBox.Show("Vaga Liberada!","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao liberar a vaga",ex.Message);
            } finally { conn.FecharConexao();}
        }

        public void AtualizarInterfaceButtons()
        {
            vagaModel.Buttons = new List<string>
    {
        "vaga1", "vaga2", "vaga3", "vaga4", "vaga5",
        "vaga6", "vaga7", "vaga8", "vaga9", "vaga10",
        "vaga11", "vaga12", "vaga13", "vaga14", "vaga15",
        "vaga16", "vaga17", "vaga18", "vaga19", "vaga20"
    };

            for (int i = 0; i < vagaModel.Buttons.Count; i++)
            {
                if (vagaModel.DisponibilidadeVagas.Count > i)
                {
                    string nomeBotao = vagaModel.Buttons[i];
                    Control[] controles = vagaView.Controls.Find(nomeBotao, true);

                    if (controles.Length > 0 && controles[0] is Button)
                    {
                        Button botao = (Button)controles[0];

                        if (vagaModel.DisponibilidadeVagas[i])
                        {
                            botao.BackColor = Color.LimeGreen;
                            botao.Enabled = true;
                        }
                        else
                        {
                            botao.BackColor = Color.Red;
                            botao.Enabled = false;
                        }
                    }
                }
            }
        }

        public VagaModel ObterVagaModel()
        {
            return vagaModel;
        }
    }
}