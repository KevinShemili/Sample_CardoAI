using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Contracts {
    public interface ILenderTypeLocalizationRepository : IBaseRepository<LenderTypeLocalization> {
        void Delete(int id, int CultureId);
        LenderTypeLocalization GetById(int id, int CultureId);
    }
}
