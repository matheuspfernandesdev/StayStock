using Dominio.Entities.Estoque;
using Dominio.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Aplicacao.Estoque
{
    public class ServicoTipoProduto : ServicoBase<TipoProduto>
    {
        public ServicoTipoProduto()
        {

        }

        public void Incluir(TipoProduto tipoProduto)
        {
            if (ValidouDuplicado(tipoProduto))
            {
                UOW.TipoProdutoRepository.Insert(tipoProduto);
                UOW.Save();
            }
            else
            {
                throw new ServiceException("Erro encontrado ao inserir: Tipo Produto já inserido com esse nome!");
            }
        }

        public List<TipoProduto> ObterTodosAtivosPorFiltro(Expression<Func<TipoProduto, bool>> filter = null,
                Func<IQueryable<TipoProduto>, IOrderedQueryable<TipoProduto>> orderBy = null,
                string includeProperties = "")
        {
            //TODO: Fazer incluir esse parametro Obter Por Filtros
            //filter = filter.And(x => x.DataHoraExclusao == null);

            return UOW.TipoProdutoRepository.Get(filter, orderBy, includeProperties).ToList();
        }

        public void Alterar(TipoProduto tipoProdutoAlterado)
        {
            if (ValidouDuplicado(tipoProdutoAlterado))
            {
                TipoProduto tipoProdutoOriginal = AtualizaTipoProdutoOriginal(tipoProdutoAlterado);

                UOW.TipoProdutoRepository.Update(tipoProdutoOriginal);
                UOW.Save();
            }
            else
            {
                throw new ServiceException("Erro encontrado ao alterar: Tipo Produto já inserido com esses dados!");
            }
        }

        public TipoProduto ObterPorId(int id)
        {
            return UOW.TipoProdutoRepository.GetByID(id);
        }

        private TipoProduto AtualizaTipoProdutoOriginal(TipoProduto tipoProdutoAlterado)
        {
            TipoProduto tipoProdutoOriginal = ObterPorId(tipoProdutoAlterado.Identificador);

            tipoProdutoOriginal.Nome = tipoProdutoAlterado.Nome;
            tipoProdutoOriginal.Descricao = tipoProdutoAlterado.Descricao;

            return tipoProdutoOriginal;
        }

        private bool ValidouDuplicado(TipoProduto tipoProduto)
        {
            TipoProduto tipoProdutoOriginal = UOW.TipoProdutoRepository.Get(x =>
                                            x.Nome == tipoProduto.Nome &&
                                            x.Identificador != tipoProduto.Identificador)
                                             .FirstOrDefault();
        
            if (tipoProdutoOriginal == null)
                return true;
            else
                return false;
        }
    }
}
