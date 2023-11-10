using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoProjetoInterdisciplinar.Model
{
    public class PagamentoModel
    {
        private bool autorizado;
        private string? descricao;
        private double valorTotal;
        private string cartao;
        private int cod_transacaoPagamento;


        public PagamentoModel() { }

        public PagamentoModel(bool autorizado, string? descricao, double valorTotal, string cartao, int cod_transacaoPagamento)
        {
            this.autorizado = autorizado;
            this.descricao = descricao;
            this.valorTotal = valorTotal;
            this.cartao = cartao;
            this.cod_transacaoPagamento = cod_transacaoPagamento;
        }

        public bool Autorizado
        {
            get { return autorizado; }
            set { autorizado = value; }
        }
        public string? Descricao { get {  return descricao; } 
            set { descricao = value; }
        }
        public double ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }
        public string Cartao 
        { 
            get { return cartao; } 
            set { cartao = value; } 
        }
        public int Cod_transacaoPagamento
        {
            get { return cod_transacaoPagamento; }
            set { cod_transacaoPagamento = value; }
        }
        public void DefinirDados(bool autorizado,string descricao,double valorTotal,string cartao,int cod_transacaoPagamento)
        {
            Autorizado = autorizado;
            Descricao = descricao;
            ValorTotal = valorTotal;
            Cartao = cartao;
            Cod_transacaoPagamento = cod_transacaoPagamento;
            
        }
    }
}
