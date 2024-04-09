using Dominio.Enums;
using System;
using System.Collections.Generic;
using UI.Models.Administrativo;
using UI.Models.Estoque;

namespace UI.Models.Vendas
{
    public class VendaViewModel : ViewModelBase
    {
        public int IdentificadorCliente { get; set; }
        public ClienteViewModel Cliente { get; set; }
        public int IdentificadorFuncionario { get; set; }
        public FuncionarioViewModel Funcionario { get; set; }
        public int? EnderecoIdentificador { get; set; }
        public EnderecoViewModel Endereco { get; set; }
        public string Observacoes { get; set; }
        public decimal ValorTotal { get; set; }
        public TipoPagamento TipoPagamento { get; set; }
        public DateTime DataHoraEntrega { get; set; }       //if null, nao precisa de entrega. cliente levou a compra
        public int QuantidadePromissoria { get; set; }

        public ICollection<PromissoriaViewModel> ListaPromissoria { get; set; }
        public ICollection<ProdutoViewModel> ListaProduto { get; set; }
    }
}