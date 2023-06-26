using Application.DomainTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts {
    public interface ILenderTypeService {
        IEnumerable<LenderTypeGetDTO> GetAllLenderTypes();
    }
}
