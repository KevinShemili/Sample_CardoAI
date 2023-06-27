using Domain.Entities;
using Repository.Contracts;

namespace Repository.Concrete {
    public class LoanRepository : BaseRepository<Loan>, ILoanRepository {
        public LoanRepository(RepositoryContext repositoryContext) : base(repositoryContext) {
        }
    }
}
