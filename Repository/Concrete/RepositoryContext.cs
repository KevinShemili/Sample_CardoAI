using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Concrete {
    public class RepositoryContext : DbContext {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options) { 
        }

        public DbSet<Loan> Loans { get; set; }
        public DbSet<Lender> Lenders { get; set; }
        public DbSet<LenderType> LenderTypes { get; set; }
        public DbSet<LenderTypeLocalization> LenderTypeLocalizations { get; set; }
        public DbSet<LoanStatus> LoanStatuses { get; set; }
        public DbSet<LoanStatusLocalization> LoanStatusLocalizations { get; set; }
    }
}
