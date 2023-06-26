using Domain.Entities;
using Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Concrete {
    public class LoanRepository : BaseRepository<Loan>, ILoanRepository {
        public LoanRepository(RepositoryContext repositoryContext) : base(repositoryContext) {
        }
    }
}
