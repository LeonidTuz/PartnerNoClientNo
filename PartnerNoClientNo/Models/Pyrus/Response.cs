using System.Text.Json;

namespace PartnerNoClientNo.Models.Pyrus
{
    public class Response
    {
        private readonly JsonSerializerOptions _options;

        public Response() 
        {
            _options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
        }

        public string FieldUpdatesJson()
        {

            var fieldUpdatesList = new List<Field>
        {
            new Field { Id = 1, Value = null },
            new Field { Id = 3, Value = new ChoiceValue { ChoiceIds = new[] { 2 } } },
            new Field { Id = 5, Value = new ChoiceValue { ChoiceIds = new[] { 2 } } },
        };

            var response = new FieldUpdates { FieldUpdate = fieldUpdatesList, ApprovalChoice = "approved" };

            var json = JsonSerializer.Serialize(response, _options);
            return json;
        }
    }
}
