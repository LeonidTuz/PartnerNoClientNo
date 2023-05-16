using System.Text.Json.Serialization;

namespace PartnerNoClientNo.Models.Pyrus
{
    public class ClientField : Field
    {
        [JsonPropertyName("value")]
        public ChoiceValue Value { get; set; }
    }
}
