using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace DAL
{
    public class TrendRepository : ITrendRepo
    {
        private TrendContext context;

        public TrendRepository(TrendContext context)
        {
            this.context = context;
        }

        public List<Trend> GetTrends()
        {
            return context.Trends.ToList();
        }

        public Trend GetTrendById(int id)
        {
            return context.Trends.Find(id);
        }

        public void CreateTrend(Trend trend)
        {
            context.Trends.Add(trend);
            context.SaveChanges();
        }

        public void UpdateTrend(Trend trend)
        {
            context.Trends.Update(trend);
            context.SaveChanges();
        }

        public void DeleteTrend(int id)
        {
            context.Remove(GetTrendById(id));
            context.SaveChanges();
        }
    }
}
