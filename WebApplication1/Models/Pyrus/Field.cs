using System.Text.Json.Serialization;

namespace PartnerNoClientNo.Models.Pyrus
{
    public class Field
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
