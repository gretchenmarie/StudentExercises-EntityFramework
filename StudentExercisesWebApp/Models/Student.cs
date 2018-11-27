using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesWebApp.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Student's Cohort")]
        [Required(ErrorMessage ="Please select a corhort")]
        public int CohortId { get; set; }
        //not in the database-for entity framework to see the relationship
        //virtual is for loading only when your code needs it (lazy loading)
        public virtual Cohort Cohort { get; set; }
        //this shows a one to many relationship-one student can have many exercises
        //icollection says this is a collection of similar things-you cannot enumerate over it 
        public virtual ICollection<StudentExercise> StudentExercises { get; set; }
    }
}