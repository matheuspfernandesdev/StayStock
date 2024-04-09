using Dominio.Entities.Administrativo;
using System.Collections.Generic;

namespace Dominio.Entities.Estoque
{
    public class Produto : EntityBase
    {
        //public int Identificador { get; set; }
        public string Nome { get; set; }
        public string NumeroSerie { get; set; }
        public decimal ValorVenda { get; set; }
        public int IdentificadorTipoProduto { get; set; }
        public TipoProduto TipoProduto { get; set; }
        public int IdentificadorFabrica { get; set; }
        public Fabrica Fabrica { get; set; }

        public ICollection<ProdutoCor> ListaProdutoCor { get; set; }
    }
}
