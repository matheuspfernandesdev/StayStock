using Dominio.Entities.Estoque;

namespace Dominio.Entities.Vendas
{
    public class VendaProdutoCor : EntityBase
    {
        //public int Identificador { get; set; }
        public int IdentificadorVenda {  get; set; }    
        public Venda Venda { get; set; }
        public int IdentificadorProdutoCor { get; set; }
        public ProdutoCor ProdutoCor { get; set; }
    }
}
