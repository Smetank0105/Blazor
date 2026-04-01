using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy_2.Components.Models
{
    public class Group
    {
        [Key]
        public int group_id { get; set; }
        public string group_name { get; set; }
        [Required, ForeignKey(nameof(Direction))]
        public byte direction { get; set; }
        public byte learning_days { get; set; }
        public TimeOnly start_time { get; set; }
        public Direction Direction { get; set; }
    }
}
