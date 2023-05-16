using System.Text.Json.Serialization;

namespace PartnerNoClientNo.Models.Pyrus
{
    public class ChoiceValue
    {
        [JsonPropertyName("choice_ids")]
        public int[] ChoiceIds { get; set; }
    }
}
