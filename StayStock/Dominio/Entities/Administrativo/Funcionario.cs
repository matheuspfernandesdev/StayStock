using Dominio.Entities.Vendas;
using Dominio.Enums;
using System.Collections.Generic;

namespace Dominio.Entities.Administrativo
{
    public class Funcionario : Pessoa
    {
        public int? EnderecoIdentificador { get; set; }
        public Endereco Endereco { get; set; }
        public string Senha { get; set; }
        public string CargaHoraria { get; set; }
        public decimal Salario { get; set; }
        public long NumeroPIS { get; set; }
        public int NumeroCarteiraTrabalho { get; set; }
        public TipoFuncionario IndicadorTipoFuncionario { get; set; }
            
        public ICollection<Venda> ListaVendas { get; set; }
        public ICollection<Vale> ListaVales{ get; set; }
        public ICollection<EmpresaLocal> ListaEmpresaLocal { get; set; }
    }
}
