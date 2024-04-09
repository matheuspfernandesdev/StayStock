using Dominio.Entities.Estoque;
using Dominio.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Aplicacao.Estoque
{
    public class ServicoCor : ServicoBase<Cor>
    {
        public ServicoCor()
        {

        }

        public void Incluir(Cor cor)
        {
            if (ValidouDuplicado(cor))
            {
                UOW.CorRepository.Insert(cor);
                UOW.Save();
            }
            else
            {
                throw new ServiceException("Erro encontrado ao inserir: Cor já inserida com esse nome!");
            }
        }

        public List<Cor> ObterTodosAtivosPorFiltro(Expression<Func<Cor, bool>> filter = null,
                Func<IQueryable<Cor>, IOrderedQueryable<Cor>> orderBy = null,
                string includeProperties = "")
        {
            //TODO: Fazer incluir esse parametro Obter Por Filtros
            //filter = filter.And(x => x.DataHoraExclusao == null);

            return UOW.CorRepository.Get(filter, orderBy, includeProperties).ToList();
        }

        public void Alterar(Cor corAlterada)
        {
            if (ValidouDuplicado(corAlterada))
            {
                Cor corOriginal = AtualizaCorOriginal(corAlterada);

                UOW.CorRepository.Update(corOriginal);
                UOW.Save();
            }
            else
            {
                throw new ServiceException("Erro encontrado ao alterar: Fábrica já inserida com esses dados!");
            }
        }

        public Cor ObterPorId(int id)
        {
            return UOW.CorRepository.GetByID(id);
        }

        private Cor AtualizaCorOriginal(Cor corAlterada)
        {
            Cor corOriginal = ObterPorId(corAlterada.Identificador);

            corOriginal.NomeCor = corAlterada.NomeCor;
            corOriginal.CodigoCor = corAlterada.CodigoCor;
            corOriginal.Descricao = corAlterada.Descricao;

            return corOriginal;
        }

        private bool ValidouDuplicado(Cor cor)
        {
            Cor corOriginal = UOW.CorRepository.Get(x =>
                                            x.NomeCor == cor.NomeCor &&
                                            x.Identificador != cor.Identificador)
                                             .FirstOrDefault();

            //Se não tem essa cor já inserida, retorna validado
            if (corOriginal == null)
                return true;
            else
                return false;
        }
    }
}
