using Core;
using Microsoft.AspNetCore.Mvc;

namespace vanderlande_api.Controllers
{
    [ApiController]
    [Route("api/")]
    public class TrendController : Controller
    {
        public List<Trend> GetTrends()
        {
            List<Trend> trends = new List<Trend>();
            return trends;
        }

        public Trend GetTrendById(int id)
        {
            Trend trend = new();
            return trend;
        }

        public void CreateTrend()
        {

        }

        public void UpdateTrend(Trend trend)
        {

        }

        public void DeleteTrend()
        {

        }
    }
}
