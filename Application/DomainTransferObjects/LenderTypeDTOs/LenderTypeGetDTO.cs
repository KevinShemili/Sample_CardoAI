using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DomainTransferObjects {
    public class LenderTypeGetDTO {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
