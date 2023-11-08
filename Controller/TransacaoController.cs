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
        ConexaoBDModel conn = new();
        public bool EfetuarTransacao(ClienteModel cliente)
        {
            try
            {
                conn.Conectar();
                Random random = new();
                int id_cliente = cliente.Id;
                int cod_transacao = random.Next(1000,10000);

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

        public void GerarComprovante(ClienteModel cliente, TransacaoModel transacao)
        {
            string localComprovante = "";
            FileInfo comprovante = new("ComprovanteReserva.xlsx");

            if (comprovante.Exists)
            {
                comprovante.Delete();
                comprovante = new FileInfo("ComprovanteReserva.xlsx");
            }
            ExcelPackage package = new(comprovante);

            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Comprovante");

            worksheet.Cells["A1"].Value = "Comprovante de Reserva";
            worksheet.Cells["A3"].Value = "Nome do Cliente:";
            worksheet.Cells["B3"].Value = cliente.Nome;
            worksheet.Cells["A4"].Value = "Modelo do Carro:";
            worksheet.Cells["B4"].Value = cliente.ModeloCarro;
            worksheet.Cells["A5"].Value = "Placa do Carro:";
            worksheet.Cells["B5"].Value = cliente.PlacaCarro;
            worksheet.Cells["A6"].Value = "Horário da Reserva:";
            worksheet.Cells["B6"].Value = transacao.Data_Transacao;
            worksheet.Cells["A7"].Value = "Código da reserva:";
            worksheet.Cells["B7"].Value = transacao.Cod_transacao;

            package.Save();

            localComprovante = comprovante.FullName;
            System.Diagnostics.Process.Start(localComprovante);

        }
    }
}
