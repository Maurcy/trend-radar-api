using Core;
using Microsoft.AspNetCore.Mvc;

namespace vanderlande_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TrendController : ControllerBase
    {
        private ITrendRepo repo;

        public TrendController(ITrendRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public List<Trend> GetTrends()
        {
            return repo.GetTrends();
        }

        [HttpGet("{id}")]
        public Trend GetTrendById(int id)
        {
            return repo.GetTrendById(id);
        }

        [HttpPost]
        public void CreateTrend(Trend trend)
        {
            trend.id = null;
            repo.CreateTrend(trend);
        }

        [HttpPut]
        public void UpdateTrend(Trend trend)
        {
            repo.UpdateTrend(trend);
        }

        [HttpDelete("{id}")]
        public void DeleteTrend(int id)
        {
            repo.DeleteTrend(id);
        }
    }
}
