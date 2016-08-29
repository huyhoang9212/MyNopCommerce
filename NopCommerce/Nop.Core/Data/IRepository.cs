using System.Collections.Generic;
using System.Linq;

namespace Nop.Core.Data
{
    public partial interface IRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// Get entity by identifier
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Entity</returns>
        T GetById(object id);

        void Insert(T entity);

        void Insert(IEnumerable<T> entities);

        void Update(T entity);

        void Update(IEnumerable<T> entities);

        void Delete(T entity);

        void Delete(IEnumerable<T> entities);

        /// <summary>
        /// Gets a table to query
        /// </summary>
        IQueryable<T> Table { get; }

        /// <summary>
        /// Gets a table with "no tracking" enabled (EF feature)
        /// Use it only when you load record(s) only for read-only operations
        /// </summary>
        IQueryable<T> TableNoTracking { get; }

    }
}
