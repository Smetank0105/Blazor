using System.ComponentModel.DataAnnotations;

namespace Academy_2.Components.Models
{
    public class Direction
    {
        [Key]
        public byte direction_id { get; set; }
        [Required]
        public string direction_name { get; set; }
        //public override bool Equals(object? obj)
        //{
        //    return this.direction_name.Equals((obj as Direction).direction_name);
        //}
        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(direction_name);
        //}
    }
}
