using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI.Models.Administrativo
{
    public class EmpresaLocalViewModel : ViewModelBase
    {
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public int EnderecoIdentificador { get; set; }
        public EnderecoViewModel Endereco { get; set; }
        public int IdentificadorFuncionarioGestor { get; set; }
        public virtual FuncionarioViewModel FuncionarioGestor { get; set; }
    }
}