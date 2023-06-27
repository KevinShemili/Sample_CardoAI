using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions {
    public class LenderTypeLocalizationNotFound : Exception {
        public LenderTypeLocalizationNotFound(int entityId, int cultureId)
            : base($"No Lender found with ID {entityId} and culture ID {cultureId}") {
        }

        public LenderTypeLocalizationNotFound() {
        }
    }
    
}
