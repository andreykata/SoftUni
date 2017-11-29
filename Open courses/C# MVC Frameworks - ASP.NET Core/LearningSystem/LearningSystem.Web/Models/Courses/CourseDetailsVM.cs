namespace LearningSystem.Web.Models.Courses
{
    using LearningSystem.Services.Models;

    public class CourseDetailsVM
    {
        public CourseDetailsSM Course { get; set; }
        public bool UserIsSignedInCourse { get; set; }
    }
}
