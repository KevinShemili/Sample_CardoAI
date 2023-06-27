using Application.DomainTransferObjects.LenderTypeDTOs;
using Application.DomainTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DomainTransferObjects.LoanStatusDTOs;

namespace Application.Contracts {
    public interface ILoanStatusService {
        IEnumerable<LoanStatusGetDTO> GetAllLoanStatuses();
        void Create(LoanStatusPostDTO loanStatusPostDTO);
        void Update(LoanStatusUpdateDTO loanStatusUpdateDTO);
        void Delete(int id);
        LoanStatusGetDTO GetById(int id);
    }
}
