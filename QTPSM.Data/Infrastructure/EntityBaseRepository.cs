using QTPSM.Data.Repositories;
using QTPSM.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QTPSM.Data.Infrastructure
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T>
            where T : class, IEntityBase, new()
    {

        private PSMContext dataContext;

        #region Properties
        protected IDbFactory DbFactory
        {
            get;
            private set;
        }

        protected PSMContext DbContext
        {
            get { return dataContext ?? (dataContext = DbFactory.Init()); }
        }
        public EntityBaseRepository(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
        }
        #endregion
        public virtual IQueryable<T> GetAll()
        {
            return DbContext.Set<T>();
        }
        /// <summary>
        /// Gets all the Data Set
        /// </summary>
        public virtual IQueryable<T> All
        {
            get
            {
                return GetAll();
            }
        }
        /// <summary>
        /// Gets all the data set including any navigation properties you select
        /// </summary>
        /// <param name="includeProperties">navigation properties</param>
        /// <returns></returns>
        public virtual IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = DbContext.Set<T>();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query;
        }
        /// <summary>
        /// Gets a single object by its ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetSingle(int id)
        {
            return GetAll().FirstOrDefault(x => x.id== id);
        }
        /// <summary>
        /// Find by a WHERE clause.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return DbContext.Set<T>().Where(predicate);
        }
        /// <summary>
        /// Adds an entity to a table
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Add(T entity)
        {
            DbEntityEntry dbEntityEntry = DbContext.Entry<T>(entity);
            DbContext.Set<T>().Add(entity);
        }
        /// <summary>
        /// Updates the entity
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Edit(T entity)
        {
            DbEntityEntry dbEntityEntry = DbContext.Entry<T>(entity);
            dbEntityEntry.State = EntityState.Modified;
        }
        /// <summary>
        /// Deletes an entity
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Delete(T entity)
        {
            DbEntityEntry dbEntityEntry = DbContext.Entry<T>(entity);
            dbEntityEntry.State = EntityState.Deleted;
        }
    }
}
