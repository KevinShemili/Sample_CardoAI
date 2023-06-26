using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions {
    public class LenderTypeNotFoundException : Exception {
        public int EntityId { get; }

        public LenderTypeNotFoundException(int entityId)
            : base($"No Lender Type found with ID {entityId}") {
            EntityId = entityId;
        }

        public LenderTypeNotFoundException() {
        }
    }
}
