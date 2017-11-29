using System;
using System.Collections.Generic;
using System.Text;
using LearningSystem.Data;
using LearningSystem.Data.Models;

namespace LearningSystem.Services.Admin.Implementations
{
    public class AdminCourseService : IAdminCourseService
    {
        private readonly LearningSystemDbContext db;

        public AdminCourseService(LearningSystemDbContext db)
        {
            this.db = db;
        }

        public void Create(string name, string description, DateTime startDate, DateTime endData, string trainerId)
        {
            var course = new Course
            {
                Name = name,
                Description = description,
                StartDate = startDate,
                EndDate = endData,
                TrainerId = trainerId
            };

            this.db.Add(course);
            this.db.SaveChanges();
        }
    }
}
