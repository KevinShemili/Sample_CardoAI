using Domain.Common;
using Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Concrete {
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity {

        protected RepositoryContext repositoryContext;

        public BaseRepository(RepositoryContext repositoryContext) {
            this.repositoryContext = repositoryContext;
        }

        public void Create(T entity) {
            repositoryContext.Set<T>().Add(entity);
            repositoryContext.SaveChanges();
        }

        public void Delete(int id) {
            var toBeDeleted = GetById(id);
            var entity = repositoryContext.Set<T>().Remove(toBeDeleted);
            repositoryContext.SaveChanges();
        }

        public IEnumerable<T> GetAll() {
            return repositoryContext.Set<T>().ToList();
        }

        public T GetById(int id) {
            var entity = repositoryContext.Set<T>().Find(id);
            if (entity == null) {
                return null;
            }
            return entity;
        }

        public void Update(T entity) {
            repositoryContext.Set<T>().Update(entity);
            repositoryContext.SaveChanges();
        }
    }
}
