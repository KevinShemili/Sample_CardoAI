using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DomainTransferObjects.LenderTypeLocalizationDTOs {
    public class LenderTypeLocalizationGetDTO {
        public int Id { get; set; }
        public int CultureId { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public int LenderTypeId { get; set; }
    }
}
