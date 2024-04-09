using Dominio.Entities.Vendas;
using System.Collections.Generic;

namespace Dominio.Entities.Administrativo
{
    public class Cliente : Pessoa
    {
        public bool ClienteEspecial { get; set; }
        public bool Inadimplente { get; set; }
        public int? EnderecoIdentificador { get; set; }
        public virtual Endereco Endereco { get; set; }

        public ICollection<Venda> ListaVendas{ get; set; }
    }
}
