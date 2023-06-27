using Application.Contracts;
using Application.DomainTransferObjects;
using Application.DomainTransferObjects.LenderDTO;
using Application.DomainTransferObjects.LenderTypeDTOs;
using AutoMapper;
using Domain.Entities;
using Domain.Exceptions;
using Repository.Concrete;
using Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Concrete {
    public class LenderService : ILenderService {
        private readonly ILenderRepository _lenderRepository;
        private readonly IMapper _mapper;

        public LenderService(IMapper mapper, ILenderRepository lenderRepository) {
            _mapper = mapper;
            _lenderRepository = lenderRepository;
        }
        public void Create(LenderPostDTO lenderPostDTO) {
            var entity = _mapper.Map<Lender>(lenderPostDTO);
            _lenderRepository.Create(entity);
        }

        public void Delete(int id) {
            var entity = _lenderRepository.GetById(id);

            if (entity == null) {
                throw new LenderNotFoundException(id);
            }

            _lenderRepository.Delete(id);
        }

        public IEnumerable<LenderGetDTO> GetAllLenders() {
            var lenders = _lenderRepository.GetAll();

            if (!lenders.Any()) {
                throw new NoLendersFound();
            }

            var lendersDto = _mapper.Map<IEnumerable<LenderGetDTO>>(lenders);

            return lendersDto;
        }

        public LenderGetDTO GetById(int id) {
            var entity = _lenderRepository.GetById(id);

            if (entity == null) {
                throw new LenderNotFoundException(id);
            }

            var entityDTO = _mapper.Map<LenderGetDTO>(entity);

            return entityDTO;
        }

        public void Update(LenderUpdateDTO lenderUpdateDTO) {
            var entity = _lenderRepository.GetById(lenderUpdateDTO.Id);

            if (entity == null) {
                throw new LenderNotFoundException(lenderUpdateDTO.Id);
            }

            _mapper.Map(lenderUpdateDTO, entity);
            _lenderRepository.Update(entity);
        }
    }
}
