﻿using System.Text.Json.Serialization;

namespace PartnerNoClientNo.Models.Pyrus
{
    public class Field: ClientField
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
