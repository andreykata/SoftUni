﻿namespace LearningSystem.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static LearningSystem.Data.DataConstants;

    public class Course
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(CourseNameMaxLength)]
        public string Name { get; set; }
        
        public string Description { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }        
        public string TrainerId { get; set; }
        public User Trainer { get; set; }

        public List<StudentCourse> Students { get; set; }
    }
}