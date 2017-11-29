using System;
using System.Collections.Generic;
using System.Text;
using LearningSystem.Services.Models;

namespace LearningSystem.Services
{
    public interface ICourseService
    {
        IEnumerable<CourseListingSM> Active();
        CourseDetailsSM ById(int id);
        bool UserIsSignedInCourse(int courseId, string userId);
        bool SignInUser(int courseId, string userId);
        bool SignOutUser(int courseId, string userId);
    }
}
