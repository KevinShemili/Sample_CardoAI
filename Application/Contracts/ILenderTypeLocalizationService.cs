using Application.DomainTransferObjects.LenderTypeDTOs;
using Application.DomainTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DomainTransferObjects.LenderTypeLocalizationDTOs;

namespace Application.Contracts {
    public interface ILenderTypeLocalizationService {
        IEnumerable<LenderTypeLocalizationGetDTO> GetAllLenderTypeLocalizations();
        void Create(LenderTypeLocalizationPostDTO lenderTypeLocalizationPostDTO);
        void Update(LenderTypeLocalizationUpdateDTO lenderTypeLocalizationUpdateDTO);
        void Delete(int id, int cultureId);
        LenderTypeLocalizationGetDTO GetById(int id, int cultureId);
    }
}
