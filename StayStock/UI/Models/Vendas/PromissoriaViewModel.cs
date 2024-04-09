using System;

namespace UI.Models.Vendas
{
    public class PromissoriaViewModel : ViewModelBase
    {
        public DateTime DataVencimento { get; set; }
        public decimal Valor { get; set; }
        public string ValorPorExtenso { get; set; }
        public int IdentificadorVenda { get; set; }
        public VendaViewModel Venda { get; set; }
    }
}