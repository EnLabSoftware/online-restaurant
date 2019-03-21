using CuttingEdge.Conditions;
using Enterprise.Logic.Exceptions;
using Enterprise.Logic.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Application.Services
{
    public abstract class BaseService<TEntity> where TEntity : Enterprise.Logic.Entities.Entity
    {
        private readonly IRepository<TEntity> _repository;

        public BaseService(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        protected TEntity GetEntity(int id, params Expression<Func<TEntity, object>>[] includes)
        {
            // string parameterName = typeof(TEntity).Name + "Id";

            //Condition.WithExceptionOnFailure<InvalidParameterException>()
            //    .Requires(id, "Id")
            //    .IsNotNullOrEmpty();

            return _repository.Get(id, includes);
        }
    }
}
