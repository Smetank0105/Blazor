using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy_3.Components.Models
{
    public class Direction
    {
        [Key, Column(TypeName = "tinyint")]
        public int direction_id { get; set; }
        [Required]
        public string direction_name { get; set; }
        public ICollection<Group> Groups { get; } = new List<Group>();
    }
}
