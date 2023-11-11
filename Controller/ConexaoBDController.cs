using System.Data;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace PrototipoProjetoInterdisciplinar.Controller
{
    public class ConexaoBDController
    {
        private MySqlConnection? mConn;
        private DataSet? mDataSet;
        private MySqlDataAdapter adapter;
        public void Conectar()

        {
            mDataSet = new DataSet();
            mConn = new MySqlConnection("Persist Security Info=false;" +
                                        "server = localhost;" +
                                        "database = estacionamento;" +
                                        "uid = root; pwd = root; ");

            try
            {
                mConn.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Conexão falhou ", ex.ToString());
            }

        }

        public MySqlDataAdapter ObterAdapter(string query)
        {
            adapter = new MySqlDataAdapter(query, mConn);
            return adapter;
        }

        public MySqlConnection ObterConexao()
            {
                return mConn;
            }

            public void FecharConexao()
            {
                if (mConn != null && mConn.State == ConnectionState.Open)
                {
                    mConn.Close();
                }
            }

    }
}
