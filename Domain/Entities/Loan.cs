using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities {
    public class Loan {
        [Key]
        [Column("Id")]
        public required int Id { get; set; }

        [Column("RequestedAmount", TypeName = "decimal(18, 2)")]
        [Required]
        public required decimal RequestedAmount { get; set; }

        [Column("FinancedAmount", TypeName = "decimal(18, 2)")]
        [Required]
        public required decimal FinancedAmount { get; set; }

        [Column("DisbursedAmount", TypeName = "decimal(18, 2)")]
        public decimal? DisbursedAmount { get; set; }

        [Column("OutstandingAmount", TypeName = "decimal(18, 2)")]
        [Required]
        public required decimal OutstandingAmount { get; set; }

        [Column("AmortizationPeriod")]
        [Required]
        public required int AmortizationPeriod { get; set; }

        [Column("PreAmortizationPeriod")]
        [Required]
        public required int PreAmortizationPeriod { get; set; }

        [Column("BrokerageFee", TypeName = "decimal(18, 4)")]
        [Required]
        public required decimal BrokerageFee { get; set; }

        [Column("APR", TypeName = "decimal(18, 4)")]
        [Required]
        public required decimal APR { get; set; }

        [Column("LenderId")]
        [Required]
        public required int LenderId { get; set; }

        [Column("LoadStatusId")]
        [Required]
        public required int LoadStatusId { get; set; }

        [Column("FDGGuaranteeId")]
        public int? FDGGuaranteeId { get; set; }

        [Column("StatusChangingTime", TypeName = "datetime2(7)")]
        public required DateTime StatusChangingTime { get; set; }

        [Column("StatusUpdateUserId")]
        public int? StatusUpdateUserId { get; set; }

        [Column("TenantId")]
        public required Guid TenantId { get; set; }

        [Column("InitialExpenses", TypeName = "decimal(18, 4)")]
        [Required]
        public required decimal InitialExpenses { get; set; }

        [Column("RemainingPreAmortizationPeriod")]
        [Required]
        public required int RemainingPreAmortizationPeriod { get; set; }

        [Column("DateDisbursed", TypeName = "datetime2(7)")]
        public DateTime? DateDisbursed { get; set; }

        [Column("UpdatedById")]
        public int? UpdatedById { get; set; }

        [Column("CreatedById")]
        public int? CreatedById { get; set; }

        [Column("IsDeleted")]
        [Required]
        public required bool IsDeleted { get; set; }

        [Column("DateCreated")]
        [Required]
        public required DateTime DateCreated { get; set; }

    }
}
