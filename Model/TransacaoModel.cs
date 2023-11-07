using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoProjetoInterdisciplinar.Model
{
    public class TransacaoModel
    {
        private int id_cliente;
        private string data_transacao;
        private double valor;
        private string descricao;

        public TransacaoModel() { }
        public TransacaoModel(int id_cliente, string data_transacao, double valor, string descricao)
        {
            this.id_cliente = id_cliente;
            this.data_transacao = data_transacao;
            this.valor = valor;
            this.descricao = descricao;
        }
       public int Id_Cliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }
        public string Data_Transacao
        {
            get { return data_transacao; }
            set { data_transacao = value;}
        }
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public void definirDados(int id_cliente, string data_transacao, double valor, string descricao)
        {
            Id_Cliente = id_cliente;
            Data_Transacao = data_transacao;
            Valor = valor;
            Descricao = descricao;  
        }
    }
}
