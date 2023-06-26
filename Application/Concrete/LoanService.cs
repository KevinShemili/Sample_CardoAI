using Application.Contracts;
using Application.DomainTransferObjects;
using Application.DomainTransferObjects.LenderTypeDTOs;
using Application.DomainTransferObjects.LoanDTOs;
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
    public class LoanService : ILoanService {

        private readonly IMapper _mapper;
        private readonly ILoanRepository _loanRepository;

        public LoanService(IMapper mapper, ILoanRepository loanRepository) {
            _mapper = mapper;
            _loanRepository = loanRepository;
        }

        public void Create(LoanPostDTO loanPostDTO) {
            var entity = _mapper.Map<Loan>(loanPostDTO);
            _loanRepository.Create(entity);
        }

        public void Delete(int id) {
            var entity = _loanRepository.GetById(id);

            if (entity == null) {
                throw new LoanNotFoundException(id);
            }

            _loanRepository.Delete(id);
        }

        public IEnumerable<LoanGetDTO> GetAllLoans() {
            var loans = _loanRepository.GetAll();

            if (!loans.Any()) {
                throw new NoLoansFound();
            }

            var loansDto = _mapper.Map<IEnumerable<LoanGetDTO>>(loans);

            return loansDto;
        }

        public LoanGetDTO GetById(int id) {
            var entity = _loanRepository.GetById(id);

            if (entity == null) {
                throw new LoanNotFoundException(id);
            }

            var entityDTO = _mapper.Map<LoanGetDTO>(entity);

            return entityDTO;
        }

        public void Update(LoanUpdateDTO loanUpdateDTO) {
            var entity = _loanRepository.GetById(loanUpdateDTO.Id);

            if (entity == null) {
                throw new LenderTypeNotFoundException(loanUpdateDTO.Id);
            }

            _mapper.Map(loanUpdateDTO, entity);
            _loanRepository.Update(entity);
        }
    }
}
