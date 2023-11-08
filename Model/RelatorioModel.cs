using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoProjetoInterdisciplinar.Model
{
    public class RelatorioModel
    {
        private string nome;
        private string endereco;
        private string telefone;
        private string documento;
        private string modeloCarro;
        private string placaCarro;
        private string data_transacao;
        private string cod_transacao;
        private string descricao;

        public RelatorioModel() { }
        public RelatorioModel(string nome, string endereco, string telefone, string documento,string modeloCarro, string placaCarro, string data_transacao, string cod_transacao, string descricao)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.telefone = telefone;
            this.documento = documento;
            this.modeloCarro = modeloCarro;
            this.placaCarro = placaCarro;
            this.data_transacao = data_transacao;
            this.cod_transacao = cod_transacao;
            this.descricao = descricao;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
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
        public string Documento
        {
            get { return documento;}
            set { documento = value; }  
        }
        public string ModeloCarro
        {
            get { return modeloCarro; }
            set { modeloCarro = value; }
        }
        public string PlacaCarro
        {
            get { return placaCarro; }
            set { placaCarro = value;}
        }
        public string DataTransacao
        {
            get { return data_transacao; }
            set { data_transacao = value;}
        }
        public string Cod_transacao
        {
            get { return cod_transacao;}
            set { cod_transacao = value;}
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public void DefinirDados(string nome, string endereco, string telefone, string documento, string modeloCarro, 
            string placaCarro, string data_transacao, string cod_transacao, string descricao)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Documento = documento;
            ModeloCarro = modeloCarro;
            PlacaCarro= placaCarro;
            DataTransacao = data_transacao;
            Cod_transacao= cod_transacao;
            Descricao = descricao;
        }

    }
}
