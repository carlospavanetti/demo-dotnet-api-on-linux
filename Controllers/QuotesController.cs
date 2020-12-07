using Microsoft.AspNetCore.Mvc;

namespace linux_demo_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuotesController : Controller
    {
        [HttpGet("{symbol}")]
        public Quote Get([FromServices] QuotesDAO dao, string symbol)
        {
            return dao.Retrieve(symbol);
        }
    }
}
