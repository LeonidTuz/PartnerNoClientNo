using System.Text.Json.Serialization;

namespace PartnerNoClientNo.Models.Pyrus
{
    public class ClientField
    {
        [JsonPropertyName("value")]
        public ChoiceValue Value { get; set; }
    }
}
