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


        public PagamentoModel() { }

        public PagamentoModel(bool autorizado, string? descricao, double valorTotal)
        {
            this.autorizado = autorizado;
            this.descricao = descricao;
            this.valorTotal = valorTotal;
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

        public void DefinirDados(bool autorizado,string descricao,double valorTotal)
        {
            Autorizado = autorizado;
            Descricao = descricao;
            ValorTotal = valorTotal;
        }
    }
}
