using System.Collections.Generic;

namespace UI.Models.Administrativo
{
    public class ClienteViewModel : PessoaViewModel
    {
        public bool ClienteEspecial { get; set; }
        public bool Inadimplente { get; set; }
        public int EnderecoIdentificador { get; set; }
        public virtual EnderecoViewModel Endereco { get; set; }
    }
}