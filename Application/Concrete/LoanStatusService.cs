using Application.Contracts;
using Application.DomainTransferObjects;
using Application.DomainTransferObjects.LenderTypeDTOs;
using Application.DomainTransferObjects.LoanStatusDTOs;
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
    public class LoanStatusService : ILoanStatusService {
        private readonly ILoanStatusRepository _loanStatusRepository;
        private readonly IMapper _mapper;

        public LoanStatusService(IMapper mapper, ILoanStatusRepository loanStatusRepository) {
            _mapper = mapper;
            _loanStatusRepository = loanStatusRepository;
        }
        public void Create(LoanStatusPostDTO loanStatusPostDTO) {
            var entity = _mapper.Map<LoanStatus>(loanStatusPostDTO);
            _loanStatusRepository.Create(entity);
        }

        public void Delete(int id) {
            var entity = _loanStatusRepository.GetById(id);

            if (entity == null) {
                throw new LoanStatusNotFoundException(id);
            }

            _loanStatusRepository.Delete(id);
        }

        public IEnumerable<LoanStatusGetDTO> GetAllLoanStatuses() {
            var loanStatuses = _loanStatusRepository.GetAll();

            if (!loanStatuses.Any()) {
                throw new NoLoanStatusesFoundException();
            }

            var loanStatusDto = _mapper.Map<IEnumerable<LoanStatusGetDTO>>(loanStatuses);

            return loanStatusDto;
        }

        public LoanStatusGetDTO GetById(int id) {
            var entity = _loanStatusRepository.GetById(id);

            if (entity == null) {
                throw new LoanStatusNotFoundException(id);
            }

            var entityDTO = _mapper.Map<LoanStatusGetDTO>(entity);

            return entityDTO;
        }

        public void Update(LoanStatusUpdateDTO loanStatusUpdateDTO) {
            var entity = _loanStatusRepository.GetById(loanStatusUpdateDTO.Id);

            if (entity == null) {
                throw new LoanStatusNotFoundException(loanStatusUpdateDTO.Id);
            }

            _mapper.Map(loanStatusUpdateDTO, entity);
            _loanStatusRepository.Update(entity);
        }
    }
}
