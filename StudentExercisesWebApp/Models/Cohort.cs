using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesWebApp.Models
{
    public class Cohort
    {
        [Key]//primary key-created in the migration
        public int CohortId { get; set; }
        //how do we want this property to be represented by the razor template(the label)
        [Display(Name="Cohort Name")]
        [Required]//for validation purposed-int the migration then it is not nullable
        public string Name { get; set; }
        //many students in one cohort
        public virtual ICollection<Student> Students { get; set; }
    }
}