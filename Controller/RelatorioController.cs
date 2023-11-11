using MySql.Data.MySqlClient;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using PrototipoProjetoInterdisciplinar.Model;
using PrototipoProjetoInterdisciplinar.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
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

                    RelatorioModel dadosCliente = new();

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

                RelatorioModel dadosCliente = new RelatorioModel();

                string sqlTransacao = "SELECT id_cliente FROM transacoes WHERE cod_transacao = @cod";
                MySqlCommand commandTransacao = new MySqlCommand(sqlTransacao, conn.ObterConexao());
                commandTransacao.Parameters.AddWithValue("@cod", cod);

                int id = 0;

                MySqlDataReader readerTransacao = commandTransacao.ExecuteReader();
                if (readerTransacao.Read())
                {
                    id = (int)readerTransacao["id_cliente"];
                }
                readerTransacao.Close();

                if (id > 0)
                {
                    string sqlCliente = "SELECT * FROM clientes WHERE id = @id";
                    MySqlCommand commandCliente = new MySqlCommand(sqlCliente, conn.ObterConexao());
                    commandCliente.Parameters.AddWithValue("@id", id);
                    MySqlDataReader readerCliente = commandCliente.ExecuteReader();

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

                    sqlTransacao = "SELECT * FROM transacoes WHERE ID_CLIENTE = @id";
                    commandTransacao = new MySqlCommand(sqlTransacao, conn.ObterConexao());
                    commandTransacao.Parameters.AddWithValue("@id", dadosCliente.Id);
                    readerTransacao = commandTransacao.ExecuteReader();

                    if (readerTransacao.Read())
                    {
                        DateTime dataTransacao = readerTransacao.GetDateTime("data_transacao");
                        dadosCliente.DataTransacao = dataTransacao.ToString("yyyy/MM/dd HH");
                        dadosCliente.Cod_transacao = readerTransacao["cod_transacao"].ToString();
                        dadosCliente.Descricao = readerTransacao["descricao"].ToString();
                    }

                    readerTransacao.Close();
                }
                else
                {
                    return null; 
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o arquivo" + ex.Message, ex.Message);
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
            DateTime dataTransacao = DateTime.ParseExact(relatorio.DataTransacao, "yyyy/MM/dd HH", CultureInfo.InvariantCulture);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage package = new(comprovante);
            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Comprovante");

            string valorConvertido ="R$ " + pagamento.ValorTotal.ToString() + ",00";
            string autorizacao = pagamento.Autorizado == true ? autorizacao = "Autorizado" : autorizacao = "Não Autorizado";

            worksheet.Cells["A1"].Value = "Comprovante de Pagamento";
            worksheet.Cells["A3"].Value = "Nome do Cliente:";
            worksheet.Cells["C3"].Value = relatorio.Nome;
            worksheet.Cells["A4"].Value = "Modelo do Carro:";
            worksheet.Cells["C4"].Value = relatorio.ModeloCarro;
            worksheet.Cells["A5"].Value = "Placa do Carro:";
            worksheet.Cells["C5"].Value = relatorio.PlacaCarro;
            worksheet.Cells["A6"].Value = "Data da reserva:";
            worksheet.Cells["C6"].Value = dataTransacao.ToString("dd/MM/yyyy HH:MM");
            worksheet.Cells["A7"].Value = "Código da reserva:";
            worksheet.Cells["C7"].Value = relatorio.Cod_transacao;
            worksheet.Cells["A8"].Value = "Valor: ";
            worksheet.Cells["C8"].Value = valorConvertido;
            worksheet.Cells["A9"].Value = "Pagamento";
            worksheet.Cells["C9"].Value = autorizacao;
            worksheet.Cells["A10"].Value = "Código da Transação:";
            worksheet.Cells["C10"].Value = pagamento.Cod_transacaoPagamento.ToString();
            worksheet.Cells["A11"].Value = "Cartão final : ";
            worksheet.Cells["C11"].Value = pagamento.Cartao;
            worksheet.Cells["A12"].Value = "Descrição: ";
            worksheet.Cells["C12"].Value = pagamento.Descricao;
            AjustarTamanhoColunas(worksheet);
            FormatHeader(worksheet, "Comprovante de Pagamento");
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
                download.FileName = "ComprovantePagamento.xlsx";
                if (download.ShowDialog() == DialogResult.OK)
                {
                    string savePatch = download.FileName;
                    File.Copy(dlComprovante, savePatch, true);
                }
               
            }
            finally
            {

            }

        }

        public void RelatorioClientes(RelatorioView relatorioView)
        {
            ConexaoBDController conn = new();

            try
            {
                conn.Conectar();

                string sql = "SELECT * FROM CLIENTES";

                MySqlDataAdapter adapter = conn.ObterAdapter(sql);

                System.Data.DataTable dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);

                relatorioView.PreencherDataGridView(dataTable); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar base de dados", ex.Message);
            } finally
            {
                conn.FecharConexao();
            }
        }

        public void RelatoriosHistoricoClientes(RelatorioView relatorioView)
        {
            ConexaoBDController conn = new();

            try
            {
                conn.Conectar();

                string sql = "SELECT c.nome AS 'Nome do Cliente', " +
                    "c.documento AS 'Documento', c.endereco AS 'Endereço',\r\n  " +
                    "  c.modeloCarro AS 'Modelo do Carro', c.telefone AS 'Telefone', c.placaCarro" +
                    " AS 'Placa do Carro',\r\n    t.data_transacao AS 'Data da Reserva', t.descricao AS" +
                    " 'Descrição'\r\nFROM transacoes t\r\nJOIN clientes c ON t.id_cliente = c.id\r\nORDER BY" +
                    " t.data_transacao DESC;";

                MySqlDataAdapter adapter = conn.ObterAdapter(sql);

                System.Data.DataTable dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);

                relatorioView.PreencherDataGridView(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar base de dados", ex.Message);
            }
            finally
            {
                conn.FecharConexao();
            }
        }

        public void RelatoriosFaturamentoMensal(RelatorioView relatorioView)
        {
            ConexaoBDController conn = new();

            try
            {
                conn.Conectar();

                string sql = "SELECT YEAR(data_transacao) AS Ano, MONTH(data_transacao) AS Mes, " +
                    "SUM(valor) AS Faturamento\r\nFROM transacoes\r\nGROUP BY YEAR(data_transacao), " +
                    "MONTH(data_transacao)\r\nORDER BY Ano DESC, Mes DESC;";

                MySqlDataAdapter adapter = conn.ObterAdapter(sql);

                System.Data.DataTable dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);

                relatorioView.PreencherDataGridView(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar base de dados", ex.Message);
            }
            finally
            {
                conn.FecharConexao();
            }
        }

        private void AjustarTamanhoColunas(ExcelWorksheet worksheet)
        {
            AutoAjusteColunas(worksheet, 'A');
            AutoAjusteColunas(worksheet, 'C');
        }

        private void AutoAjusteColunas(ExcelWorksheet worksheet, char coluna)
        {
            var colunaStr = coluna.ToString();
            using ExcelRange colunas = worksheet.Cells[$"{colunaStr}:{colunaStr}"];
            colunas.AutoFitColumns();
        }

        public void FormatHeader(ExcelWorksheet worksheet, string headerText)
        {
            var header = worksheet.Cells["A1:C1"];

            header.Merge = true;
            header.Style.Font.Bold = true;
            header.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left; 

            worksheet.Cells["A1:C1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left; 
            worksheet.Cells["A1:C1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            worksheet.Cells["A1"].Value = headerText;
        }
    }
}
