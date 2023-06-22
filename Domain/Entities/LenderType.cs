using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common;

namespace Domain.Entities {
    public class LenderType : BaseEntity {
        [Key]
        [Column("Id")]
        public required int Id { get; set; }

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
    }
}
