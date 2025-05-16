using Core;
using Microsoft.AspNetCore.Mvc;

namespace vanderlande_api.Controllers
{
    [ApiController]
    [Route("api")]
    public class TrendController : Controller
    {
        ITrendRepo repo;

        public TrendController(ITrendRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet("GetTrends")]
        public List<Trend> GetTrends()
        {
            return repo.GetTrends();
        }

        [HttpGet("{id}")]
        public Trend GetTrendById(int id)
        {
            return repo.GetTrendById(id);
        }

        [HttpPost("CreateTrend")]
        public void CreateTrend(Trend trend)
        {
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
