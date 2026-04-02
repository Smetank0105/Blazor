using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy_3.Components.Models
{
    public class Direction
    {
        [Key, Column(TypeName = "tinyint")]
        public int direction_id { get; set; }
        [UniqueDirectionName(errorMessage: "Error: Такое направление уже существует")]
        public string direction_name { get; set; }
    }
}
