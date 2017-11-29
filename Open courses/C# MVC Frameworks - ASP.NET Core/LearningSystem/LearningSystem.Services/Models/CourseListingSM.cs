using System;
using System.Collections.Generic;
using System.Text;
using LearningSystem.Common.Mapping;
using LearningSystem.Data.Models;

namespace LearningSystem.Services.Models
{
    public class CourseListingSM : IMapFrom<Course>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
