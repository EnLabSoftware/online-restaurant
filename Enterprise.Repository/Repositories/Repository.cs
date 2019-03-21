using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data.Entity;
using Enterprise.Logic.Repositories;
using Enterprise.Logic.Entities;
using System.Linq.Expressions;

namespace Enterprise.Repository.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        private EnterpriseEntities _session = null;
        public EnterpriseEntities Session
        {
            get
            {
                return _session;
            }
        }

        public Repository(EnterpriseEntities session)
        {
            _session = session;
        }

        public DbSet<TEntity> Entities
        {
            get
            {
                return Session.Set<TEntity>();
            }
        }

        public TEntity Get(int id, params Expression<Func<TEntity, object>>[] includes)
        {
            var query = Session.Set<TEntity>().Where(_ => _.Id == id);

            return includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty)).FirstOrDefault();
        }

        public IList<TEntity> GetAll(params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = Session.Set<TEntity>();

            return includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty)).ToList();
        }
        
        public bool Add(TEntity entity)
        {
            if (!IsValid(entity))
                return false;
            try
            {
                this.Session.Set<TEntity>().Add(entity);

                return this.Session.Entry(entity).GetValidationResult().IsValid;
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                    throw new Exception(ex.InnerException.Message, ex);
                else
                    throw new Exception(ex.Message, ex);
            }
        }

        public bool Update(TEntity entity)
        {
            if (!IsValid(entity))
                return false;
            try
            {
                this.Session.Entry(entity).State = System.Data.Entity.EntityState.Modified;

                return this.Session.Entry(entity).GetValidationResult().IsValid;
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                    throw new Exception(ex.InnerException.Message, ex);
                else
                    throw new Exception(ex.Message, ex);
            }
        }

        public bool Delete(TEntity entity)
        {
            if (!IsValid(entity))
                return false;
            try
            {
                this.Session.Entry(entity).State = System.Data.Entity.EntityState.Deleted;

                return this.Session.Entry(entity).GetValidationResult().IsValid;
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                    throw new Exception(ex.InnerException.Message, ex);
                else
                    throw new Exception(ex.Message, ex);
            }
        }

        public bool IsValid(TEntity entity)
        {
            return this.Session.Entry(entity).GetValidationResult().IsValid;
        }

        public bool Save()
        {
            try
            {
                return (this.Session.SaveChanges() >= 0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
