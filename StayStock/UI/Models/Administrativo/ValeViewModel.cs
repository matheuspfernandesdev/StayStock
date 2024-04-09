using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI.Models.Administrativo
{
    public class ValeViewModel : ViewModelBase
    {
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public int IdentificadorFuncionarioVale { get; set; }
        public FuncionarioViewModel FuncionarioVale { get; set; }
    }
}