using Data.UOW;
using Dominio.Entities;
using Dominio.Framework;
using System;
using System.Linq.Expressions;

namespace Aplicacao
{
    public class ServicoBase<TEntity> where TEntity : EntityBase
    {
        protected UnitOfWork UOW { get; set; }

        public ServicoBase()
        {
            this.UOW = new UnitOfWork();
        }

        private Expression<Func<TEntity, bool>> IncluirFiltroAtivos(Expression<Func<TEntity, bool>> filter)
        {
            if (filter != null)
                return filter.And(x => x.DataHoraExclusao == null);
            else
                return (x => x.DataHoraExclusao == null);
        }


        //TODO: Será que dá pra deixar esse método genérico?
        //public List<TEntity> ObterTodosAtivosPorFiltro(Expression<Func<TEntity, bool>> filter = null,
        //        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        //        string includeProperties = "")
        //{
        //    if (filter != null)
        //        filter = filter.And(IncluirFiltroAtivos);
        //    else
        //        return (x => x.DataHoraExclusao == null);

        //    return UOW.FabricaRepository.Get(filter, orderBy, includeProperties).ToList();
        //}

    }
}
