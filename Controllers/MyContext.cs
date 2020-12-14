using Microsoft.EntityFrameworkCore;

namespace LogReg.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }

        public DbSet<LogReg> LogRegs { get; set; }
    }
}