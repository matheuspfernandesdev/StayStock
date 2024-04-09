using System;
using Dominio.Entities;
using Data.Context;
using Data.Repositories;
using Dominio.Entities.Vendas;
using Dominio.Entities.Estoque;
using Dominio.Entities.Administrativo;
using System.Collections.Generic;
using System.Linq;

namespace Data.UOW
{
    public class UnitOfWork : IDisposable
    {
        private ContextStayStock context = new ContextStayStock();

        #region [Administrativo]

        private readonly GenericRepository<Cliente> clienteRepository;
        public GenericRepository<Cliente> ClienteRepository
        {
            get
            {
                return this.clienteRepository ?? new GenericRepository<Cliente>(context);
            }
        }

        private readonly GenericRepository<EmpresaLocal> empresaLocalRepository;
        public GenericRepository<EmpresaLocal> EmpresaLocalRepository
        {
            get
            {
                return this.empresaLocalRepository ?? new GenericRepository<EmpresaLocal>(context);
            }
        }

        private readonly GenericRepository<Endereco> enderecoRepository;
        public GenericRepository<Endereco> EnderecoRepository
        {
            get
            {
                return this.enderecoRepository ?? new GenericRepository<Endereco>(context);
            }
        }

        private readonly GenericRepository<Fabrica> fabricaRepository;
        public GenericRepository<Fabrica> FabricaRepository
        {
            get
            {
                return this.fabricaRepository ?? new GenericRepository<Fabrica>(context);
            }
        }

        public List<Fabrica> RetornaFabricas()
        {
            List<Fabrica> lista = new List<Fabrica>();

            //EXEMPLO DE COMO USAR O INCLUDE PRA CARREGAR COM EAGER LOADING
            lista = context.FabricaDbSet
                        .Include("Endereco")
                        .Include("ListaProdutos")
                        .Include("ListaProdutos.ListaProdutoCor")
                        //.Where(s => s.Nome == "Rumo IT")
                        .ToList();

            return lista;
        }

        private readonly GenericRepository<Financeira> financeiraRepository;
        public GenericRepository<Financeira> FinanceiraRepository
        {
            get
            {
                return this.financeiraRepository ?? new GenericRepository<Financeira>(context);
            }
        }

        private readonly GenericRepository<Funcionario> funcionarioRepository;
        public GenericRepository<Funcionario> FuncionarioRepository
        {
            get
            {
                return this.funcionarioRepository ?? new GenericRepository<Funcionario>(context);
            }
        }

        private readonly GenericRepository<Vale> valeRepository;
        public GenericRepository<Vale> ValeRepository
        {
            get
            {
                return this.valeRepository ?? new GenericRepository<Vale>(context);
            }
        }

        #endregion

        #region [Estoque]

        private readonly GenericRepository<Cor> corRepository;
        public GenericRepository<Cor> CorRepository
        {
            get
            {
                return this.corRepository ?? new GenericRepository<Cor>(context);
            }
        }

        private readonly GenericRepository<Produto> produtoRepository;
        public GenericRepository<Produto> ProdutoRepository
        {
            get
            {
                return this.produtoRepository ?? new GenericRepository<Produto>(context);
            }
        }

        private readonly GenericRepository<ProdutoCor> produtoCorRepository;
        public GenericRepository<ProdutoCor> ProdutoCorRepository
        {
            get
            {
                return this.produtoCorRepository ?? new GenericRepository<ProdutoCor>(context);
            }
        }

        private readonly GenericRepository<ProdutoEmEstoque> produtoEmEstoqueRepository;
        public GenericRepository<ProdutoEmEstoque> ProdutoEmEstoqueRepository
        {
            get
            {
                return this.produtoEmEstoqueRepository ?? new GenericRepository<ProdutoEmEstoque>(context);
            }
        }

        private readonly GenericRepository<TipoProduto> tipoProdutoRepository;
        public GenericRepository<TipoProduto> TipoProdutoRepository
        {
            get
            {
                return this.tipoProdutoRepository ?? new GenericRepository<TipoProduto>(context);
            }
        }

        #endregion

        #region [Vendas]

        private readonly GenericRepository<Venda> vendaRepository;
        public GenericRepository<Venda> VendaRepository
        {
            get
            {
                return this.vendaRepository ?? new GenericRepository<Venda>(context);
            }
        }

        private readonly GenericRepository<VendaProdutoCor> vendaProdutoCorRepository;
        public GenericRepository<VendaProdutoCor> VendaProdutoCorRepository
        {
            get
            {
                return this.vendaProdutoCorRepository ?? new GenericRepository<VendaProdutoCor>(context);
            }
        }

        private readonly GenericRepository<Promissoria> promissoriaRepository;
        public GenericRepository<Promissoria> PromissoriaRepository
        {
            get
            {
                return this.promissoriaRepository ?? new GenericRepository<Promissoria>(context);
            }
        }

        #endregion

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }

            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
