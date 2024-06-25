using Microsoft.EntityFrameworkCore;
using TorstaiCupAC.Models;

namespace TorstaiCupAC.Data
{
    public class TorstaiCupContext : DbContext
    {
        protected readonly IConfiguration _configuration;

        public DbSet<Driver> Drivers { get; set; }

        public TorstaiCupContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_configuration.GetConnectionString("TorstaiCupDB"));
        }
    }
}
