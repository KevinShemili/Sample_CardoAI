using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions {
    public class NoLoanStatusesFoundException : Exception {
        public NoLoanStatusesFoundException()
            : base($"No Loan Statuses Exist.") {
        }
    }
}
