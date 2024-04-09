
using Dominio.Entities.Vendas;
using System;
using System.Collections.Generic;

namespace Dominio.Entities.Administrativo
{
    public class Endereco : EntityBase
    {
        //public int Identificador { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }                  //É string pois pode ter um número 157 A, B ou C
        public int CEP { get; set; }
        public string Municipio { get; set; }


        public virtual ICollection<Fabrica> Fabrica { get; set; }
        public virtual ICollection<Funcionario> Funcionario { get; set; }
        public virtual ICollection<Cliente> Cliente { get; set; }
        public virtual ICollection<Venda> Venda { get; set; }
        public virtual ICollection<EmpresaLocal> EmpresaLocal { get; set; }

        public Endereco()
        {
            DataHoraInclusao = DateTime.Now;
            DataHoraUltimaAlteracao = DateTime.Now;
        }
    }
}
