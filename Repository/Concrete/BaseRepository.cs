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

        public void Delete(T entity) {
            throw new NotImplementedException();
        }

        public ICollection<T> GetAll() {
            throw new NotImplementedException();
        }

        public T GetById(int id) {
            throw new NotImplementedException();
        }

        public void Update(T entity) {
            throw new NotImplementedException();
        }
    }
}
