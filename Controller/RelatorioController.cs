using MySql.Data.MySqlClient;
using OfficeOpenXml;
using PrototipoProjetoInterdisciplinar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoProjetoInterdisciplinar.Controller
{
    public class RelatorioController
    {


        ConexaoBDController conn = new();


        public RelatorioModel ObterDadosCliente(int idCliente)
        {
            try
            {
                conn.Conectar();

                
                string sqlCliente = "SELECT * FROM clientes WHERE ID = @id";
                MySqlCommand commandCliente = new MySqlCommand(sqlCliente, conn.ObterConexao());
                commandCliente.Parameters.AddWithValue("@id", idCliente);
                MySqlDataReader readerCliente = commandCliente.ExecuteReader();

                RelatorioModel dadosCliente = new RelatorioModel();

                if (readerCliente.Read())
                {
                    dadosCliente.Id = (int)readerCliente["id"];
                    dadosCliente.Nome = readerCliente["nome"].ToString();
                    dadosCliente.Endereco = readerCliente["endereco"].ToString();
                    dadosCliente.Telefone = readerCliente["telefone"].ToString();
                    dadosCliente.Documento = readerCliente["documento"].ToString();
                    dadosCliente.ModeloCarro = readerCliente["modeloCarro"].ToString();
                    dadosCliente.PlacaCarro = readerCliente["placaCarro"].ToString();
                }

                readerCliente.Close(); 

                
                string sqlTransacao = "SELECT * FROM transacoes WHERE ID_CLIENTE = @id";
                MySqlCommand commandTransacao = new MySqlCommand(sqlTransacao, conn.ObterConexao());
                commandTransacao.Parameters.AddWithValue("@id", dadosCliente.Id);
                MySqlDataReader readerTransacao = commandTransacao.ExecuteReader();

                if (readerTransacao.Read())
                {
                    dadosCliente.DataTransacao = readerTransacao["data_transacao"].ToString();
                    dadosCliente.Cod_transacao = readerTransacao["cod_transacao"].ToString();
                    dadosCliente.Descricao = readerTransacao["descricao"].ToString();
                }

                return dadosCliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar a base de dados", ex.Message);
                return null;
            }
            finally
            {
                conn.FecharConexao();
            }
        }

            public RelatorioModel ObterDadosCliente_Nome(string nome)
            {
                try
                {
                    conn.Conectar();

                    string sqlCliente = "SELECT * FROM clientes WHERE NOME LIKE @nome";
                    MySqlCommand commandCliente = new MySqlCommand(sqlCliente, conn.ObterConexao());
                    commandCliente.Parameters.AddWithValue("@nome", "%" + nome + "%");
                    MySqlDataReader readerCliente = commandCliente.ExecuteReader();

                    RelatorioModel dadosCliente = new RelatorioModel();

                    if (readerCliente.Read())
                    {
                        dadosCliente.Id = (int)readerCliente["id"];
                        dadosCliente.Nome = readerCliente["nome"].ToString();
                        dadosCliente.Endereco = readerCliente["endereco"].ToString();
                        dadosCliente.Telefone = readerCliente["telefone"].ToString();
                        dadosCliente.Documento = readerCliente["documento"].ToString();
                        dadosCliente.ModeloCarro = readerCliente["modeloCarro"].ToString();
                        dadosCliente.PlacaCarro = readerCliente["placaCarro"].ToString();
                    
                    }

                    readerCliente.Close();


                    string sqlTransacao = "SELECT * FROM transacoes WHERE ID_CLIENTE = @id";
                    MySqlCommand commandTransacao = new MySqlCommand(sqlTransacao, conn.ObterConexao());
                    commandTransacao.Parameters.AddWithValue("@id", dadosCliente.Id);
                    MySqlDataReader readerTransacao = commandTransacao.ExecuteReader();

                    if (readerTransacao.Read())
                    {
                        DateTime dataTransacao = readerTransacao.GetDateTime("data_transacao");
                        dadosCliente.DataTransacao = dataTransacao.ToString("yyyy/MM/dd HH");
                        dadosCliente.Cod_transacao = readerTransacao["cod_transacao"].ToString();
                        dadosCliente.Descricao = readerTransacao["descricao"].ToString();
                    }

                    return dadosCliente;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao consultar a base de dados", ex.Message);
                    return null;
                }
                finally
                {
                    conn.FecharConexao();
                }
            }

        public RelatorioModel ObterDadosCliente_Cod(int cod)
        {
            try
            {
                conn.Conectar();

                string sqlCliente = "SELECT * FROM clientes WHERE cod_transacao = @cod";
                MySqlCommand commandCliente = new MySqlCommand(sqlCliente, conn.ObterConexao());
                commandCliente.Parameters.AddWithValue("@cod_transacao",cod);
                MySqlDataReader readerCliente = commandCliente.ExecuteReader();

                RelatorioModel dadosCliente = new RelatorioModel();

                if (readerCliente.Read())
                {
                    dadosCliente.Id = (int)readerCliente["id"];
                    dadosCliente.Nome = readerCliente["nome"].ToString();
                    dadosCliente.Endereco = readerCliente["endereco"].ToString();
                    dadosCliente.Telefone = readerCliente["telefone"].ToString();
                    dadosCliente.Documento = readerCliente["documento"].ToString();
                    dadosCliente.ModeloCarro = readerCliente["modeloCarro"].ToString();
                    dadosCliente.PlacaCarro = readerCliente["placaCarro"].ToString();
                }

                readerCliente.Close();


                string sqlTransacao = "SELECT * FROM transacoes WHERE ID_CLIENTE = @id";
                MySqlCommand commandTransacao = new MySqlCommand(sqlTransacao, conn.ObterConexao());
                commandTransacao.Parameters.AddWithValue("@id", dadosCliente.Id);
                MySqlDataReader readerTransacao = commandTransacao.ExecuteReader();

                if (readerTransacao.Read())
                {
                    dadosCliente.DataTransacao = readerTransacao["data_transacao"].ToString();
                    dadosCliente.Cod_transacao = readerTransacao["cod_transacao"].ToString();
                    dadosCliente.Descricao = readerTransacao["descricao"].ToString();
                }

                return dadosCliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar a base de dados", ex.Message);
                return null;
            }
            finally
            {
                conn.FecharConexao();
            }
        }

        public void ComprovanteTransacao(RelatorioModel relatorio,PagamentoModel pagamento)
        {
            string localComprovante = "";
            string dlComprovante = Path.GetTempFileName();
            FileInfo comprovante = new("ComprovantePagamento.xlsx");

            if (comprovante.Exists)
            {
                comprovante.Delete();
                comprovante = new FileInfo("ComprovantePagamento.xlsx");
            }

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage package = new(comprovante);
            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Comprovante");

            worksheet.Cells["A1"].Value = "Comprovante de Pagamento";
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o arquivo", ex.Message);
                File.WriteAllBytes(dlComprovante, package.GetAsByteArray());
                SaveFileDialog download = new();
                download.Filter = "Arquivos Excel (*.xlsx)|*.xlsx";
                download.FileName = "ComprovanteReserva.xlsx";
                if (download.ShowDialog() == DialogResult.OK)
                {
                    string savePatch = download.FileName;
                    File.Copy(dlComprovante, savePatch, true);
                }
                // File.Delete(download.FileName);
            }
            finally
            {

            }

        }

    }
}
