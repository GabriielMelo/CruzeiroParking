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
                int cod_transacao = GerarCodigoTransacao();

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

        public int GerarCodigoTransacao()
        {
            Random random = new();
            int cod_transacao = random.Next(1000, 10000);
            return cod_transacao;
        }

        public void GerarComprovante(RelatorioModel relatorio)
        {
            string localComprovante = "";
            string dlComprovante = Path.GetTempFileName();
            FileInfo comprovante = new("ComprovanteReserva.xlsx");

            if (comprovante.Exists)
            {
                comprovante.Delete();
                comprovante = new FileInfo("ComprovanteReserva.xlsx");
            }

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage package = new(comprovante);
            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Comprovante");

            worksheet.Cells["A1"].Value = "Comprovante de Reserva";
            worksheet.Cells["A3"].Value = "Nome do Cliente:";
            worksheet.Cells["C3"].Value = relatorio.Nome;
            worksheet.Cells["A4"].Value = "Modelo do Carro:";
            worksheet.Cells["C4"].Value = relatorio.ModeloCarro;
            worksheet.Cells["A5"].Value = "Placa do Carro:";
            worksheet.Cells["C5"].Value = relatorio.PlacaCarro;
            worksheet.Cells["A6"].Value = "Data da reserva:";
            worksheet.Cells["C6"].Value = relatorio.DataTransacao;
            worksheet.Cells["A7"].Value = "Código da reserva:";
            worksheet.Cells["C7"].Value = relatorio.Cod_transacao;

            try
            {
                package.Save();
                localComprovante = comprovante.FullName;
                System.Diagnostics.Process.Start(localComprovante);
            } catch(Exception ex)
            {
                MessageBox.Show("Erro ao abrir o arquivo", ex.Message);
                File.WriteAllBytes(dlComprovante, package.GetAsByteArray());
                SaveFileDialog download = new();
                download.Filter = "Arquivos Excel (*.xlsx)|*.xlsx";
                download.FileName = "ComprovanteReserva.xlsx";
                if(download.ShowDialog() == DialogResult.OK)
                {
                    string savePatch = download.FileName;
                    File.Copy(dlComprovante, savePatch, true);
                }
                // File.Delete(download.FileName);
            } finally
            {

            }
            

        }
    }
}
