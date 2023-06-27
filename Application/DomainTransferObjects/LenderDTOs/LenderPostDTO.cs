using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DomainTransferObjects.LenderDTO {
    public class LenderPostDTO {
        public string Name { get; set; }
        public Guid TenantId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int LenderTypeId { get; set; }
        public string CodiceSoggetoEnte { get; set; }
        public int FundManagerId { get; set; }
    }
}
