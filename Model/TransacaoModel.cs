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
        private int cod_transacao;

        public TransacaoModel() { }
        public TransacaoModel(int id_cliente, string data_transacao, double valor, string descricao, int cod_transacao)
        {
            this.id_cliente = id_cliente;
            this.data_transacao = data_transacao;
            this.valor = valor;
            this.descricao = descricao;
            this.cod_transacao = cod_transacao;
        }

        public int Cod_transacao
        {
            get { return cod_transacao; }
            set { cod_transacao = value; }
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
        public void definirDados(int id_cliente, string data_transacao, double valor, string descricao,int cod_transacao)
        {
            Id_Cliente = id_cliente;
            Data_Transacao = data_transacao;
            Valor = valor;
            Descricao = descricao;  
            Cod_transacao = cod_transacao;
        }
    }
}
