using Dominio.Entities.Estoque;
using System.Collections.Generic;

namespace Dominio.Entities.Administrativo
{
    public class Fabrica : EntityBase
    {
        //public int Identificador { get; set; }
        public string Nome { get; set; }
        //public ICollection<Endereco> Enderecos { get; set; }
        public int? EnderecoIdentificador { get; set; }
        public Endereco Endereco { get; set; }
        public string CNPJ { get; set; }
        public string Email { get; set; }
        public string Descricao { get; set; }
        public string Telefone { get; set; }
        public ICollection<Produto> ListaProdutos { get; set; }
    }
}
