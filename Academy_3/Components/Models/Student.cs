using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy_3.Components.Models
{
    public class Student:Human
    {
        [Key]
        public int stud_id { get; set; }
        [Required, ForeignKey(nameof(Group))]
        public int group { get; set; }

        //Nav prop
        public Group Group { get; set; }
    }
}
