namespace Dominio.Entities.Estoque
{
    public class ProdutoEmEstoque : EntityBase
    {
        //public int Identificador { get; set; }
        public int IdentificadorProdutoCor { get; set; }
        public ProdutoCor ProdutoCor { get; set; }
        public int Quantidade { get; set; }

        //OBS: Provavelmente o mapeamento foi feito da maneira errada.
        //Bastava colocar a quantidade de ProdutoCor em estoque dentro da clase ProdutoCor
    }
}
