using Dominio.Entities.Vendas;
using System.Collections.Generic;

namespace Dominio.Entities.Estoque
{
    public class ProdutoCor : EntityBase
    {
        //public int Identificador { get; set; }
        public int? IdentificadorCor { get; set; }
        public Cor Cor { get; set; }
        public int IdentificadorProduto { get; set; }
        public Produto Produto { get; set; }
        public string Descricao { get; set; }

        public ICollection<ProdutoEmEstoque> ListaProdutosEmEstoque { get; set; }
        public ICollection<VendaProdutoCor> ListaVendaProdutoCor { get; set; }
    }
}
