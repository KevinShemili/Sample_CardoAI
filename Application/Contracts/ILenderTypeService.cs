using Application.DomainTransferObjects;
using Application.DomainTransferObjects.LenderTypeDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts {
    public interface ILenderTypeService {
        IEnumerable<LenderTypeGetDTO> GetAllLenderTypes();
        void Create(LenderTypePostDTO lenderTypePostDTO);

        void Update(LenderTypeUpdateDTO lenderTypePostDTO);

        void Delete(int id);

        LenderTypeGetDTO GetById(int id);

    }
}
