using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoProjetoInterdisciplinar.Model
{
    public class FuncionarioModel
    {
       
        private string nome;
        private string usuario;
        private string senha;

        // -------------------------------------------------------------


        
        public FuncionarioModel() { }

        public FuncionarioModel(string nome, string usuario, string senha)
        {
            this.nome = nome;
            this.usuario = usuario;
            this.senha = senha;
        }

        // -------------------------------------------------------------

        
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
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
        // -------------------------------------------------------------

        
        public void definirDados(string nome, string usuario, string senha)
        {
            Nome = nome;
            Usuario = usuario;
            Senha = senha;
        }

        // ------------------------ FIM DA CLASSE-------------------------------------
    }
}
