using Dominio.Entities.Estoque;
using Dominio.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Aplicacao.Estoque
{
    public class ServicoProdutoCor : ServicoBase<Produto>
    {
        public ServicoProdutoCor()
        {

        }

        public void Incluir(ProdutoCor produtoCor)
        {
            if (ValidouDuplicado(produtoCor))
            {
                UOW.ProdutoCorRepository.Insert(produtoCor);
                UOW.Save();
            }
            else
            {
                throw new ServiceException("Erro encontrado ao inserir: Tipo Produto já inserido com esse nome!");
            }
        }

        public List<ProdutoCor> ObterTodosAtivosPorFiltro(Expression<Func<ProdutoCor, bool>> filter = null,
                Func<IQueryable<ProdutoCor>, IOrderedQueryable<ProdutoCor>> orderBy = null,
                string includeProperties = "")
        {
            //TODO: Fazer incluir esse parametro Obter Por Filtros
            //filter = filter.And(x => x.DataHoraExclusao == null);

            return UOW.ProdutoCorRepository.Get(filter, orderBy, includeProperties).ToList();
        }

        public void Alterar(ProdutoCor produtoCorAlterado)
        {
            if (ValidouDuplicado(produtoCorAlterado))
            {
                ProdutoCor produtoCorOriginal = AtualizaTipoProdutoOriginal(produtoCorAlterado);

                UOW.ProdutoCorRepository.Update(produtoCorOriginal);
                UOW.Save();
            }
            else
            {
                throw new ServiceException("Erro encontrado ao alterar: Tipo Produto já inserido com esses dados!");
            }
        }

        public ProdutoCor ObterPorId(int id)
        {
            return UOW.ProdutoCorRepository.GetByID(id);
        }

        public ProdutoCor ObterPorIdEagerLoading(int id)
        {
            ProdutoCor produtoCor = ObterTodosAtivosPorFiltro(x => x.Identificador == id, null, "Cor,Produto,Produto.TipoProduto,Produto.Fabrica,ListaProdutosEmEstoque").FirstOrDefault();

            //if (produtoCor.IdentificadorCor != 0)
            //    produtoCor.Cor = UOW.CorRepository.GetByID(produtoCor.IdentificadorCor);

            //if (produtoCor.IdentificadorProduto != 0)
            //    produtoCor.Produto = UOW.ProdutoRepository.GetByID(produtoCor.IdentificadorProduto);

            //produtoCor.ListaProdutosEmEstoque = UOW.ProdutoEmEstoqueRepository.Get(x => x.ProdutoCor.Identificador == id, null, "").ToList();

            return produtoCor; 
        }

        private ProdutoCor AtualizaTipoProdutoOriginal(ProdutoCor produtoAlterado)
        {
            ProdutoCor produtoOriginal = ObterPorId(produtoAlterado.Identificador);

            //produtoOriginal.Nome = produtoAlterado.Nome;

            return produtoOriginal;
        }

        private bool ValidouDuplicado(ProdutoCor produtoCor)
        {
            ProdutoCor produtoOriginal = UOW.ProdutoCorRepository.Get(x =>
                                            //x.Nome == produto.Nome &&
                                            x.Identificador != produtoCor.Identificador)
                                             .FirstOrDefault();

            if (produtoOriginal == null)
                return true;
            else
                return false;
        }
    }
}
