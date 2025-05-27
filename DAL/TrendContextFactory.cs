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
            optionsBuilder.UseNpgsql("Host=dpg-d0qnu0jipnbc73eic3i0-a;Port=5432;Database=trenddatabase;Username=dbi525146_trends;Password=G7EAbSmFlZ3n7tTpw0oT8hWSSWAsykRq;SSL Mode=Require;Trust Server Certificate=true;");

            return new TrendContext(optionsBuilder.Options);
        }
    }
}
