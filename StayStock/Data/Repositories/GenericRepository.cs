using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Data.Repositories
{
    public class teste : EntityBase
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class GenericRepository<Entity> where Entity : EntityBase
    {
        internal DbContext context;
        internal DbSet<Entity> dbSet;

        public GenericRepository(DbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<Entity>();

            //dbSet.Include("Endereco");
        }

        public virtual IEnumerable<Entity> Get(
            Expression<Func<Entity, bool>> filter = null,
            Func<IQueryable<Entity>, IOrderedQueryable<Entity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<Entity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public virtual Entity GetByID(object id)
        {
            return dbSet.Find(id);
        }

        public virtual Entity GetByIDWithInclude(int id, string includeProperties = "")
        {
            IQueryable<Entity> query = dbSet;
            foreach (var includeProperty in includeProperties.Split
                    (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            return query.FirstOrDefault(x => x.Identificador == id);
        }

        public virtual void Insert(Entity entity)
        {
            dbSet.Add(entity);
            entity.DataHoraInclusao = DateTime.Now;
            entity.DataHoraUltimaAlteracao = DateTime.Now;
            entity.DataHoraExclusao = null;
        }

        public virtual void Delete(object id)
        {
            Entity entity = dbSet.Find(id);
            //Delete(entity);
            entity.DataHoraUltimaAlteracao = DateTime.Now;
            entity.DataHoraExclusao = DateTime.Now;
        }

        public virtual void Update(Entity entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            entity.DataHoraUltimaAlteracao = DateTime.Now;
        }
        
    }
}
