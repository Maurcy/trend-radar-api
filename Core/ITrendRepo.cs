using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface ITrendRepo
    {
        List<Trend> GetTrends();
        Trend GetTrendById(int id);
        void CreateTrend(Trend trend);
        public void UpdateTrend(Trend trend);
        public void DeleteTrend(int id);
    }
}
