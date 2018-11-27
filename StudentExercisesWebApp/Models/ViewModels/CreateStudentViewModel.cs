using Microsoft.AspNetCore.Mvc.Rendering;
using StudentExercisesWebApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesWebApp.Models.ViewModels
{
    public class CreateStudentViewModel
    {
        public Student Student { get; set; }
        public List<SelectListItem> AvailableExercises { get; private set; }

        [Display(Name ="Selected Exercises")]
        public List<int> SelectedExercises { get; set; }
        public List<SelectListItem> Cohorts { get; set; }

        public CreateStudentViewModel() { }
        public CreateStudentViewModel(ApplicationDbContext ctx)
        { //in dapper yo uwrite a sql statement-here you write context.exercise.ToList
            List<Exercise> AllExercises = ctx.Exercises.ToList();
            //select is similar to map in javascript  //lambda expression makes each list item a new selectlist item
            AvailableExercises = AllExercises.Select(li => new SelectListItem()
            {
                Text = li.Name,
                Value = li.ExerciseId.ToString()
            }).ToList();
            //context is the part of entity framework that connects to the database
            Cohorts = ctx.Cohorts.Select(li => new SelectListItem()
            {
                Text = li.Name,
                Value = li.CohortId.ToString()
            }).ToList();
        }
    }
}
