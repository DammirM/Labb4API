using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Labb4API.Models
{
    public class Link
    {
        [Key]
        public int ID { get; set; }
        public string? Url { get; set; }
        public int? PersonId { get; set; }
        [JsonIgnore]
        public Person? Person { get; set; }
        public int? InterestId { get; set; }
        [JsonIgnore]
        public Interest? Interest { get; set; }
    }
}
