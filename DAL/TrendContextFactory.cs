using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DAL
{
    public class TrendContextFactory : IDesignTimeDbContextFactory<TrendContext>
    {
        public TrendContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TrendContext>();

            // Replace this with your actual local or dev connection string
            optionsBuilder.UseSqlServer("Server=mssqlstud.fhict.local;Database=dbi525146_trends;User Id=dbi525146_trends;Password=trends;");

            return new TrendContext(optionsBuilder.Options);
        }
    }
}
