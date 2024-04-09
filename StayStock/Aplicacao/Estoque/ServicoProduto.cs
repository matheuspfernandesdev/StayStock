using Dominio.Entities.Estoque;
using Dominio.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Aplicacao.Estoque
{
    public class ServicoProduto : ServicoBase<Produto>
    {
        public ServicoProduto()
        {

        }

        public void Incluir(Produto produto)
        {
            if (ValidouDuplicado(produto))
            {
                UOW.ProdutoRepository.Insert(produto);
                UOW.Save();
            }
            else
            {
                throw new ServiceException("Erro encontrado ao inserir: Tipo Produto já inserido com esse nome!");
            }
        }

        public List<Produto> ObterTodosAtivosPorFiltro(Expression<Func<Produto, bool>> filter = null,
                Func<IQueryable<Produto>, IOrderedQueryable<Produto>> orderBy = null,
                string includeProperties = "")
        {
            //TODO: Fazer incluir esse parametro Obter Por Filtros
            //filter = filter.And(x => x.DataHoraExclusao == null);

            return UOW.ProdutoRepository.Get(filter, orderBy, includeProperties).ToList();
        }

        public void Alterar(Produto produtoAlterado)
        {
            if (ValidouDuplicado(produtoAlterado))
            {
                Produto produtoOriginal = AtualizaTipoProdutoOriginal(produtoAlterado);

                UOW.ProdutoRepository.Update(produtoOriginal);
                UOW.Save();
            }
            else
            {
                throw new ServiceException("Erro encontrado ao alterar: Tipo Produto já inserido com esses dados!");
            }
        }

        public Produto ObterPorId(int id)
        {
            return UOW.ProdutoRepository.GetByID(id);
        }

        private Produto AtualizaTipoProdutoOriginal(Produto produtoAlterado)
        {
            Produto produtoOriginal = ObterPorId(produtoAlterado.Identificador);

            produtoOriginal.Nome = produtoAlterado.Nome;

            return produtoOriginal;
        }

        private bool ValidouDuplicado(Produto produto)
        {
            Produto produtoOriginal = UOW.ProdutoRepository.Get(x =>
                                            x.Nome == produto.Nome &&
                                            x.Identificador != produto.Identificador)
                                             .FirstOrDefault();

            if (produtoOriginal == null)
                return true;
            else
                return false;
        }
    }
}
