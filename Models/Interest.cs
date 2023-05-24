using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Labb4API.Models
{
    public class Interest
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Link>? Links { get; set; }

    }
}
