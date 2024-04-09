using System;

namespace UI.Models.Administrativo
{
    public class PessoaViewModel : ViewModelBase
    {
        public string Nome { get; set; }
        public char Sexo { get; set; }
        public string CodigoCpfCnpj { get; set; }
        public string Identidade { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}