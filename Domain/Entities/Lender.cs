using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common;

namespace Domain.Entities {
    public class Lender : BaseEntity {
        [Key]
        [Column("Id")]
        public required int Id { get; set; }

        [Column("Name")]     
        [StringLength(500)]
        public string? Name { get; set; }

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

        [Column("LenderTypeId")]
        [Required]
        public required int LenderTypeId { get; set; }

        [Column("CodiceSoggetoEnte")]
        [StringLength(50)]
        public int? CodiceSoggetoEnte { get; set; }

        [Column("FundManagerId")]
        public int? FundManagerId { get; set; }

        public virtual ICollection<Loan> Loans { get; set; }
        
        [ForeignKey("LenderTypeId")]
        public virtual LenderType LenderType { get; set; }

    }
}
