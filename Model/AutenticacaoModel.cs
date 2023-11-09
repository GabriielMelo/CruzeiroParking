using MySql.Data.MySqlClient;
using PrototipoProjetoInterdisciplinar.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PrototipoProjetoInterdisciplinar.Controllers
{
    public class AutenticacaoModel
    {
        ConexaoBDController conn = new ConexaoBDController();

        private string usuario;
        private string senha;

        public AutenticacaoModel() { }
        public AutenticacaoModel(string usuario,string senha)
        {
            this.usuario = usuario;
            this.senha = senha;
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        
        public void definirDados(string usuario,string senha)
        {
            Usuario = usuario;
            Senha = senha;
        }

        
    }
}
