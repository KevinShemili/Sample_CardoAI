using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common;

namespace Domain.Entities {
    public class LenderTypeLocalization : BaseEntity {

        [Key]
        [Column("Id")]
        public required int Id { get; set; }

        [Column("CultureId")]
        public required int CultureId { get; set; }

        [Column("IsDeleted")]
        [Required]
        public required bool IsDeleted { get; set; }

        [Column("Name")]
        [StringLength(500)]
        [Required]
        public required string Name { get; set; }
    }
}
