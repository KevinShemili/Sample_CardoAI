using Application.Contracts;
using Application.DomainTransferObjects;
using AutoMapper;
using Domain.Entities;
using Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Concrete {
    public class LenderTypeService : ILenderTypeService {


        private readonly ILenderTypeRepository _lenderTypeRepository;
        private readonly IMapper _mapper;

        public LenderTypeService(IMapper mapper, ILenderTypeRepository lenderTypeRepository) {
            _mapper = mapper;
            _lenderTypeRepository = lenderTypeRepository;
        }

        public IEnumerable<LenderTypeGetDTO> GetAllLenderTypes() {
            var lenderTypes = _lenderTypeRepository.GetAll();
            var lenderTypesDto = _mapper.Map<IEnumerable<LenderTypeGetDTO>>(lenderTypes);
                
            return lenderTypesDto;
        }
    }
}
