using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static BullFins.Models.EF_Models;


namespace BullFins.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Company> Companies { get; set; }
        public DbSet<StockStats> StockStatistics { get; set; }
        public DbSet<SymbolFinancial> SymbolFinancials { get; set; }
    }
}
