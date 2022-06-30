using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int CourseID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [Range(0, 5)]
        public int Credits { get; set; }

        public int DepartmentID { get; set; } //EF Core doesn't require a foreign key property for a data model when the model has a navigation property for a related entity.

        public Department Department { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; } // course can have any number of students enrolled in it, so the Enrollments navigation property is a collection
        public ICollection<Instructor> Instructors { get; set; } //A course may be taught by multiple instructors, so the Instructors navigation property is a collection
    }
}