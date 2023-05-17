using Microsoft.AspNetCore.Mvc;
using PartnerNoClientNo.Models.Pyrus;
using System.Text.Json;

namespace PartnerNoClientNo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PartnerNoController : Controller
    {

        Response response = new Response();

        [HttpPost]
        public async Task<IActionResult> SetClientNoPartnerNoDueNull()
        {
            string json = response.FieldUpdatesJson();

            try
            {
                return Ok(json);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }
    }
}
