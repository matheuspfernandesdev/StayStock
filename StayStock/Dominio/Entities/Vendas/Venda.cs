using Dominio.Entities.Administrativo;
using Dominio.Enums;
using System;
using System.Collections.Generic;

namespace Dominio.Entities.Vendas
{
    public class Venda : EntityBase
    {
        //public int Identificador { get; set; }
        public int IdentificadorCliente { get; set; }
        public Cliente Cliente { get; set; }
        public int IdentificadorFuncionario { get; set; }
        public Funcionario Funcionario { get; set; }
        public int? EnderecoIdentificador { get; set; }
        public Endereco Endereco { get; set; }
        public string Observacoes { get; set; }
        public decimal ValorTotal { get; set; }
        public TipoPagamento TipoPagamento { get; set; }
        public DateTime DataHoraEntrega { get; set; }       //if null, nao precisa de entrega. cliente levou a compra
        public int QuantidadePromissoria { get; set; }

        public ICollection<Promissoria> ListaPromissoria { get; set; }
        public ICollection<VendaProdutoCor> ListaVendaProdutoCor { get; set; }
        //public byte ComprovantePagamentoCartao { get; set; }
    }
}
