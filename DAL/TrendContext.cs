using Core;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class TrendContext : DbContext
    {
        public TrendContext(DbContextOptions<TrendContext> options) : base(options) { }
        public DbSet<Trend> Trends { get; set; }
    }
}
