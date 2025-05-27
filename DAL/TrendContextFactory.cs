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
            optionsBuilder.UseNpgsql("postgresql://dbi525146_trends:G7EAbSmFlZ3n7tTpw0oT8hWSSWAsykRq@dpg-d0qnu0jipnbc73eic3i0-a/trenddatabase");

            return new TrendContext(optionsBuilder.Options);
        }
    }
}
