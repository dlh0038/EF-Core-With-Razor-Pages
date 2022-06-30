using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class OfficeAssignment
    {
        [Key] //The [Key] attribute is used to identify a property as the primary key (PK) when the property name is something other than classnameID or ID
        public int InstructorID { get; set; }
        [StringLength(50)]
        [Display(Name = "Office Location")]
        public string Location { get; set; }

        public Instructor Instructor { get; set; } //The OfficeAssignment.Instructor navigation property will always have an instructor entity because the foreign key InstructorID type is int, a non-nullable value type. An office assignment can't exist without an instructor.
    }
}