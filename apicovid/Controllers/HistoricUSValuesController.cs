using apicovid.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apicovid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoricUSValuesController : ControllerBase
    {
        [HttpGet]
        [Authorize(Roles = "buscador")]
        public IActionResult Get()
        {
                using (ApirestpruebaContext db = new ApirestpruebaContext())
                {
                var list= (from d in db.HistoricUsvalues select d).ToList();
                   return Ok(list);
                }
        }
    }
}
