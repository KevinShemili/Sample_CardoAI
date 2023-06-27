using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DomainTransferObjects.LenderTypeLocalizationDTOs {
    public class LenderTypeLocalizationUpdateDTO {
        public int Id { get; set; }
        public int CultureId { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public int LenderTypeId { get; set; }
    }
}
