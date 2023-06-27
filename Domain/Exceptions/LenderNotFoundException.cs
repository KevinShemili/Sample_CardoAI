using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions {
    public class LenderNotFoundException : Exception {
        public int EntityId { get; }
        public LenderNotFoundException(int entityId)
            : base($"No Lender found with ID {entityId}") {
            EntityId = entityId;
        }

        public LenderNotFoundException() {
        }
    }
}
