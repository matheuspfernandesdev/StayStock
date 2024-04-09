using System;

namespace Dominio.Entities.Vendas
{
    public class Promissoria : EntityBase
    {
        //public int Identificador { get; set; }
        public DateTime DataVencimento { get; set; }
        public decimal Valor { get; set; }
        public string ValorPorExtenso { get; set; } 
        public int IdentificadorVenda { get; set; }
        public Venda Venda { get; set; }
    }
}
