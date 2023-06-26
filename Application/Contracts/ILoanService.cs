using Application.DomainTransferObjects.LenderTypeDTOs;
using Application.DomainTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DomainTransferObjects.LoanDTOs;

namespace Application.Contracts {
    public interface ILoanService {
        IEnumerable<LoanGetDTO> GetAllLoans();
        void Create(LoanPostDTO loanPostDTO);
        void Update(LoanUpdateDTO loanUpdateDTO);
        void Delete(int id);
        LoanGetDTO GetById(int id);
    }
}
