using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions {
    public class NoLenderTypeLocalizationsFound : Exception {
        public NoLenderTypeLocalizationsFound()
            : base($"No Lender Type Localizations Exist.") {
        }
    }
}
