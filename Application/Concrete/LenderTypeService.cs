using Application.Contracts;
using Application.DomainTransferObjects;
using Application.DomainTransferObjects.LenderTypeDTOs;
using AutoMapper;
using Domain.Entities;
using Domain.Exceptions;
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

        public void Create(LenderTypePostDTO lenderTypePostDTO) {
            var entity = _mapper.Map<LenderType>(lenderTypePostDTO);
            _lenderTypeRepository.Create(entity);
        }

        public void Delete(int id) {
            var entity = _lenderTypeRepository.GetById(id);

            if (entity == null) {
                throw new LenderTypeNotFoundException(id);
            }

            _lenderTypeRepository.Delete(id);
        }

        public IEnumerable<LenderTypeGetDTO> GetAllLenderTypes() {
            var lenderTypes = _lenderTypeRepository.GetAll();

            if (!lenderTypes.Any()) {
                throw new NoLoansFound();
            }

            var lenderTypesDto = _mapper.Map<IEnumerable<LenderTypeGetDTO>>(lenderTypes);
                
            return lenderTypesDto;
        }

        public LenderTypeGetDTO GetById(int id) {
            var entity = _lenderTypeRepository.GetById(id);

            if (entity == null) {
                throw new LenderTypeNotFoundException(id);
            }

            var entityDTO = _mapper.Map<LenderTypeGetDTO>(entity);

            return entityDTO;
        }

        public void Update(LenderTypeUpdateDTO lenderTypeUpdateDTO) {
           
            var entity = _lenderTypeRepository.GetById(lenderTypeUpdateDTO.Id);

            if (entity == null) {
                throw new LenderTypeNotFoundException(lenderTypeUpdateDTO.Id); 
            }

            _mapper.Map(lenderTypeUpdateDTO, entity);
            _lenderTypeRepository.Update(entity);
        }
    }
}
