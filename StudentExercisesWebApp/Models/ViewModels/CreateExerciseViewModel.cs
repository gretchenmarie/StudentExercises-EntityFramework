﻿using Microsoft.AspNetCore.Mvc.Rendering;
using StudentExercisesWebApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace StudentExercisesWebApp.Models.ViewModels
{
    public class CreateExerciseViewModel
    {
        
            public Exercise Exercise { get; set; }
            public List<SelectListItem> AvailableStudents { get; private set; }

            [Display(Name = "Select Student")]
            public List<int> SelectedStudents { get; set; }
           // public List<SelectListItem> Cohorts { get; set; }

            public CreateExerciseViewModel() { }
            public CreateExerciseViewModel(ApplicationDbContext ctx)
            {
                List<Student> AllStudents = ctx.Students.ToList();
                AvailableStudents = AllStudents.Select(li => new SelectListItem()
                {
                    Text = li.FullName,
                   
                    Value = li.StudentId.ToString()
                }).ToList();

               /* Cohorts = ctx.Cohorts.Select(li => new SelectListItem()
                {
                    Text = li.Name,
                    Value = li.CohortId.ToString()
                }).ToList();*/
            }
        }
    }

