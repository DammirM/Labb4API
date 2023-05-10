using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Labb4API.Models
{
    public class Person
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string? Phone { get; set; }
        [JsonIgnore]
        public ICollection<Link>? Links { get; set; }
    }
}
