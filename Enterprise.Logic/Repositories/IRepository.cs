using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Logic.Repositories
{
    public interface IRepository<TEntity> where TEntity: Entities.Entity
    {
        TEntity Get(int id, params Expression<Func<TEntity, object>>[] includes);

        IList<TEntity> GetAll(params Expression<Func<TEntity, object>>[] includes);

        //IList<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);

        bool Add(TEntity entity);

        bool Update(TEntity entity);

        bool Delete(TEntity entity);

        bool IsValid(TEntity entity);

        bool Save();
    }
}
