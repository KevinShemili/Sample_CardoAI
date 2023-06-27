using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions {
    public class LoanStatusNotFoundException : Exception {
        public int EntityId { get; }
        public LoanStatusNotFoundException(int entityId)
            : base($"No Loan Status found with ID {entityId}") {
            EntityId = entityId;
        }

        public LoanStatusNotFoundException() {
        }
    }
}
