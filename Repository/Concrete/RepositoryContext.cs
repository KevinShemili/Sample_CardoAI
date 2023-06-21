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
    }
}
