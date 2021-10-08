using HealthCheck.Contracts.Base.Context;
using HealthCheck.Contracts.Base.Interfaces.Repository;
using HealthCheck.Models.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HealthCheck.Contracts.Implementations
{
    public abstract class Repository<T> : IRepository<T> where T : Entity
    {
        private HealthCheckDbContext _myDbContext;


        public Repository(HealthCheckDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }
        public void Add(T entity)
        {
            try
            {
                _myDbContext.Add(entity);
                _myDbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public virtual void Delete(int id)
        {
            try
            {
                var entity = _myDbContext.Set<T>().FirstOrDefault(x => x.Id == id);

                if (entity != null)
                {
                    _myDbContext.Remove(entity);
                    _myDbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public virtual IList<T> FindAll()
        {
            try
            {
                return _myDbContext.Set<T>().ToList();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public virtual T FindById(int id)
        {
            try
            {
                return _myDbContext.Set<T>().FirstOrDefault(x => x.Id == id);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public virtual void Update(T entity)
        {
            try
            {
                _myDbContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _myDbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public virtual T FindBy(Func<T, bool> predicate)
        {
            try
            {
                return _myDbContext.Set<T>().FirstOrDefault(predicate);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
