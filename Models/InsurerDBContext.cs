using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceClaim_Microservice.Models
{
    public class InsurerDBContext:DbContext
    {
        public InsurerDBContext(DbContextOptions<InsurerDBContext> options) : base(options)
        {

        }

        public DbSet<InsurerDetail> InsurerDetails { get; set; }
        public DbSet<InitiateClaim> InitiateClaims { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

        
    }
}
