using Microsoft.AspNetCore.Mvc;
using PartnerNoClientNo.Models.Pyrus;
using System.Text.Json;

namespace PartnerNoClientNo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PartnerNoController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> SetClientNoPartnerNoDueNull()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var fieldUpdatesList = new List<Field>
            {
                new Field { Id = 1, Value = null },
                new Field { Id = 3, Value = new ChoiceValue { ChoiceIds = new[] { 2 } } },
                new Field { Id = 5, Value = new ChoiceValue { ChoiceIds = new[] { 2 } } },
            };

            var response = new FieldUpdates { FieldUpdate =  fieldUpdatesList, ApprovalChoice = "approved"};

            try
            {
                
                var json = JsonSerializer.Serialize(response, options);
                return Ok(json);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
