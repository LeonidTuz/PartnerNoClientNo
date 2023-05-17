using Microsoft.AspNetCore.Mvc;
using PartnerNoClientNo.Models.Pyrus;
using System.Text.Json;

namespace PartnerNoClientNo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PartnerNoController : Controller
    {
        readonly string _json;
        public PartnerNoController() 
        {
            Response response = new Response();
            _json = response.FieldUpdatesJson();
        }

        [HttpPost]
        public async Task<IActionResult> SetClientNoPartnerNoDueNull()
        {

            try
            {
                return Ok(_json);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }
    }
}
