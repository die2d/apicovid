using apicovid.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apicovid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoricAllStateValuesController : ControllerBase
    {

        [HttpGet]
        [Authorize(Roles = "ciudadano")]
        public IActionResult Get()
        {
            using (ApirestpruebaContext db = new ApirestpruebaContext())
            {
                var list = (from d in db.HistoricAllStatesValues select d).ToList();
                return Ok(list);
            }
        }
    }
}
