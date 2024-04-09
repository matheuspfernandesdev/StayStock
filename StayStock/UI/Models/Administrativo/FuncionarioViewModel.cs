using Dominio.Enums;
using System.Collections.Generic;

namespace UI.Models.Administrativo
{
    public class FuncionarioViewModel : PessoaViewModel
    {
        public int EnderecoIdentificador { get; set; }
        public EnderecoViewModel Endereco { get; set; }
        public string Senha { get; set; }
        public string CargaHoraria { get; set; }
        public decimal Salario { get; set; }
        public long NumeroPIS { get; set; }
        public int NumeroCarteiraTrabalho { get; set; }
        public TipoFuncionario IndicadorTipoFuncionario { get; set; }
    }
}