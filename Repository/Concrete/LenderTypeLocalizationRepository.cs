using Domain.Entities;
using Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Repository.Concrete {
    public class LenderTypeLocalizationRepository : BaseRepository<LenderTypeLocalization>, ILenderTypeLocalizationRepository {
        public LenderTypeLocalizationRepository(RepositoryContext repositoryContext) : base(repositoryContext) {
        }

        public void Delete(int id, int cultureId) {
            var toBeDeleted = GetById(id, cultureId);
            var entity = repositoryContext.Set<LenderTypeLocalization>().Remove(toBeDeleted);
            repositoryContext.SaveChanges();
        }

        public LenderTypeLocalization GetById(int id, int cultureId) {
            var entity = repositoryContext.Set<LenderTypeLocalization>().Find(id, cultureId);
            if (entity == null) {
                return null;
            }
            return entity;
        }
    }
}
