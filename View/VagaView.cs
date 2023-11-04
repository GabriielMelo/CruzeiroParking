using MySql.Data.MySqlClient;
using PrototipoProjetoInterdisciplinar.Controller;
using PrototipoProjetoInterdisciplinar.Controllers;
using PrototipoProjetoInterdisciplinar.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoProjetoInterdisciplinar.View
{
    public partial class VagaView : Form
    {

        ConexaoBDModel conn = new ConexaoBDModel();

        public VagaView()
        {
            InitializeComponent();

        }



        public void AtualizarStatusVaga(int idVaga)
        {
            DialogResult result = MessageBox.Show("Deseja preencher esta vaga?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {


                string sql = "UPDATE Vagas SET disponivel = false WHERE id_vaga = @idVaga";
                MySqlCommand command = new MySqlCommand(sql, conn.ObterConexao());
                command.Parameters.AddWithValue("@idVaga", idVaga);
                int atualizado = command.ExecuteNonQuery();

                if (atualizado > 0)
                {
                    MessageBox.Show("Vaga atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar a vaga!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }

        }






    }

}

