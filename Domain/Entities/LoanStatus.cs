using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common;

namespace Domain.Entities {
    public class LoanStatus : BaseEntity {
        [Key]
        [Column("Id")]
        public required int Id { get; set; }

        [Column("TenantId")]
        [Required]
        public required Guid TenantId { get; set; }

        [Column("IsDeleted")]
        [Required]
        public required bool IsDeleted { get; set; }

        [Column("DateCreated", TypeName = "datetime2(7)")]
        [Required]
        public required DateTime DateCreated { get; set; }

        [Column("DateUpdated", TypeName = "datetime2(7)")]
        [Required]
        public DateTime? DateUpdated { get; set; }

        [Column("IsPredefined")]
        public required bool IsPredefined { get; set; }
        
        [Column("LocalizationId")]
        public required int LocalizationId { get; set; }

        [ForeignKey("LocalizationId")]
        public virtual ICollection<LoanStatusLocalization> LoanStatusLocalizations { get; set; }

        public virtual Loan Loan { get; set; }

    }
}
