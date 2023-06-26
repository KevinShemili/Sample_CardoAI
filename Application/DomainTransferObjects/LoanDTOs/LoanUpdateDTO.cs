using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DomainTransferObjects.LoanDTOs {
    public class LoanUpdateDTO {
        public int Id { get; set; }
        public decimal RequestedAmount { get; set; }
        public decimal FinancedAmount { get; set; }
        public decimal DisbursedAmount { get; set; }
        public decimal OutstandingAmount { get; set; }
        public int AmortizationPeriod { get; set; }
        public int PreAmortizationPeriod { get; set; }
        public decimal BrokerageFee { get; set; }
        public decimal APR { get; set; }
        public int LenderId { get; set; }
        public int LoanStatusId { get; set; }
        public int FDGGuaranteeId { get; set; }
        public DateTime StatusChangingTime { get; set; }
        public int StatusUpdateUserId { get; set; }
        public Guid TenantId { get; set; }
        public decimal InitialExpenses { get; set; }
        public int RemainingPreAmortizationPeriod { get; set; }
        public DateTime DateDisbursed { get; set; }
        public int UpdatedById { get; set; }
        public int CreatedById { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
