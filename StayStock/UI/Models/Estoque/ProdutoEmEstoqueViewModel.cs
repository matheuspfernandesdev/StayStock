using System.Collections.Generic;

namespace UI.Models.Estoque
{
    public class ProdutoEmEstoqueViewModel : ViewModelBase
    {
        public int IdentificadorProdutoCor { get; set; }
        public ProdutoCorViewModel ProdutoCorViewModel { get; set; }

        public int Quantidade { get; set; }

        public ICollection<ProdutoViewModel> ListaProduto { get; set; }
    }
}