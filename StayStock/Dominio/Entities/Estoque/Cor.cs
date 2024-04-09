using System.Collections.Generic;

namespace Dominio.Entities.Estoque
{
    public class Cor : EntityBase
    {
        //public int Identificador { get; set; }
        public string NomeCor { get; set; }
        public string CodigoCor { get; set; }      
        public string Descricao { get; set; }

        public ICollection<ProdutoCor> ListaProdutoCor { get; set; }
    }
}
