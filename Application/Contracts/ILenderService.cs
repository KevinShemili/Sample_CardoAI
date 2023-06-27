using Application.DomainTransferObjects.LenderTypeDTOs;
using Application.DomainTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DomainTransferObjects.LenderDTO;

namespace Application.Contracts {
    public interface ILenderService {
        IEnumerable<LenderGetDTO> GetAllLenders();

        void Create(LenderPostDTO lenderPostDTO);

        void Update(LenderUpdateDTO lenderUpdateDTO);

        void Delete(int id);

        LenderGetDTO GetById(int id);

    }
}
