using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebApplication1;
using PartnerNoClientNo.Models.Pyrus;
using System.Text.Json;
using System.Runtime.CompilerServices;

namespace PartnerNoClientNo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PartnerNoController : Controller
    {

        private readonly RequestApiPyrus _pyrusApi;
        private string fielPath = "C:\\Users\\tuzle\\Desktop\\NoCreds\\creds.txt";
        public PartnerNoController(RequestApiPyrus pyrusApi)
        {
            _pyrusApi = pyrusApi;
        }

        [HttpPost]
        public async Task<IActionResult> SetClientNoPartnerNoDueNull()
        {
            var a = new ClientField { Id = 3, Value = new ChoiceValue { ChoiceIds = new[] { 2 } } };   
            try
            {
                var response = await _pyrusApi.GetTaskInfo(taskId);
                var json = JsonSerializer.Serialize(response);
                return Ok(json);
            }
            catch (Exception ex)
            {
                // здесь можно добавить логирование ошибок
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }





    }
}
