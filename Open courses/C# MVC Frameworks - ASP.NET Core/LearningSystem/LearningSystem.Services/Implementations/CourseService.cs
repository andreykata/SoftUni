using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper.QueryableExtensions;
using LearningSystem.Data;
using LearningSystem.Data.Models;
using LearningSystem.Services.Models;

namespace LearningSystem.Services.Implementations
{
    public class CourseService : ICourseService
    {
        private readonly LearningSystemDbContext db;

        public CourseService(LearningSystemDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<CourseListingSM> Active()
        {
            var courses = this.db
                .Courses
                .OrderByDescending(c => c.Id)
                .Where(c => c.StartDate >= DateTime.UtcNow)
                .ProjectTo<CourseListingSM>()
                .ToList();

            return courses;
        }

        public CourseDetailsSM ById(int id)
        {
            var course = this.db
                .Courses
                .Where(c => c.Id == id)
                .ProjectTo<CourseDetailsSM>()
                .FirstOrDefault();

            return course;
        }

        public bool SignInUser(int courseId, string userId)
        {
            var courseInfo = this.db
                .Courses
                .Where(c => c.Id == courseId)
                .Select(c => new
                {
                    c.StartDate,
                    UserIdSignedIn = c.Students.Any(s => s.StudentId == userId)
                })
                .FirstOrDefault();

            if (courseInfo == null || courseInfo.StartDate < DateTime.UtcNow || courseInfo.UserIdSignedIn)
            {
                return false;
            }

            var studentInCourse = new StudentCourse
            {
                StudentId = userId,
                CourseId = courseId
            };

            this.db.Add(studentInCourse);
            this.db.SaveChanges();

            return true;
        }

        public bool SignOutUser(int courseId, string userId)
        {
            var courseInfo = this.db
                .Courses
                .Where(c => c.Id == courseId)
                .Select(c => new
                {
                    c.StartDate,
                    UserIdSignedIn = c.Students.Any(s => s.StudentId == userId)
                })
                .FirstOrDefault();

            if (courseInfo == null || courseInfo.StartDate < DateTime.UtcNow || !courseInfo.UserIdSignedIn)
            {
                return false;
            }

            var userInCourse = this.db.Find<StudentCourse>(courseId, userId);

            this.db.Remove(userInCourse);
            this.db.SaveChanges();

            return true;
        }

        public bool UserIsSignedInCourse(int courseId, string userId)
        {
            return this.db
                .Courses
                .Any(c => c.Id == courseId && c.Students.Any(s => s.StudentId == userId));
        }
    }
}
