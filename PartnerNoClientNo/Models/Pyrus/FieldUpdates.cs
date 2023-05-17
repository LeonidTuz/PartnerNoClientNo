using System.Text.Json.Serialization;

namespace PartnerNoClientNo.Models.Pyrus
{
    public class FieldUpdates
    {
        [JsonPropertyName("field_updates")]
        public List<Field>? FieldUpdate { get; set; }
        [JsonPropertyName("approval_choice")]
        public string? ApprovalChoice { get; set; }

    }
}