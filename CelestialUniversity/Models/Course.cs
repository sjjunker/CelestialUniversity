﻿using CelestialUniversity.Models;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CelestialUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int CourseID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [Required]
        [Range(0, 5)]
        public int Credits { get; set; }

        public int DepartmentID { get; set; }

        public Department? Department { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; } = [];
        public ICollection<CourseAssignment> CourseAssignments { get; set; } = [];
    }
}
