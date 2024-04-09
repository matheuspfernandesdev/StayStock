using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entities.Administrativo
{
    public class Vale : EntityBase
    {
        //public int Identificador { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public int IdentificadorFuncionarioVale { get; set; }
        public Funcionario FuncionarioVale { get; set; }
    }
}
    