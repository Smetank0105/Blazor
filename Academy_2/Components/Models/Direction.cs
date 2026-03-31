using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Academy_2.Components.Models
{
    public class Direction
    {
        [Key]
        public byte direction_id { get; set; }
        [Required]
        [UniqueDirectionName(errorMessage: "Error: Такое направление уже существует")]
        public string direction_name { get; set; }
        public List<Group> Groups { get; set; } = new List<Group>();
    }
}
