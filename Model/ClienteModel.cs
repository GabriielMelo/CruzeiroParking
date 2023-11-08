using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PrototipoProjetoInterdisciplinar.Controllers
{

    public class ClienteModel
    {

        private int id;
        private string nome;
        private string documento;
        private string endereco;
        private string telefone;
        private string modeloCarro;
        private string placaCarro;

        // -------------------------------------------------------------

        public ClienteModel() { }

        public ClienteModel(int id,string nome, string documento, string endereco, 
            string telefone, string modeloCarro, string placaCarro)
        {
            this.id = id;
            this.nome = nome;
            this.documento = documento;
            this.endereco = endereco;
            this.telefone = telefone;
            this.modeloCarro = modeloCarro;
            this.placaCarro = placaCarro;
        }

        // -------------------------------------------------------------

        public int Id { 
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
                get { return nome; }
                set { nome = value; }
        }

        public string Documento
        {
            get { return documento; }
            set { documento = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string ModeloCarro
        {
            get { return modeloCarro; }
            set { modeloCarro = value; }
        }

        public string PlacaCarro
        {
            get { return placaCarro; }
            set { placaCarro = value; }
        }

        // -------------------------------------------------------------

        public void definirDados(string nome, string documento, string endereco, string telefone, string modeloCarro, string placaCarro)
        {
            Id = id;
            Nome = nome;
            Documento = documento;
            Endereco = endereco;
            Telefone = telefone;
            ModeloCarro = modeloCarro;
            PlacaCarro = placaCarro;
        }

        // ------------------------ FIM DA CLASSE-------------------------------------

    }

}

