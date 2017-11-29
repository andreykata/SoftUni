namespace LearningSystem.Web.Controllers
{
    using LearningSystem.Data.Models;
    using LearningSystem.Services;
    using LearningSystem.Web.Infrastructure.Extensions;
    using LearningSystem.Web.Models.Courses;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class CoursesController : Controller
    {
        private readonly ICourseService courses;
        private readonly UserManager<User> userManager;

        public CoursesController(ICourseService courses, UserManager<User> userManager)
        {
            this.courses = courses;
            this.userManager = userManager;
        }

        public IActionResult Details(int id)
        {
            var model = new CourseDetailsVM
            {
                Course = this.courses.ById(id)
            };

            if (model.Course == null)
            {
                return this.NotFound();
            }
            
            if (User.Identity.IsAuthenticated)
            {
                var userId = this.userManager.GetUserId(User);

                model.UserIsSignedInCourse = this.courses.UserIsSignedInCourse(id, userId);
            }

            return View(model);
        }

        [Authorize]
        [HttpPost]
        public IActionResult SignIn(int id)
        {
            var userId = this.userManager.GetUserId(User);
            var success = this.courses.SignInUser(id, userId);

            if (!success)
            {
                return BadRequest();
            }

            TempData.AddSuccessMessage("Thank you for your sign in!");
            return RedirectToAction(nameof(Details), new { id });
        }

        [Authorize]
        [HttpPost]
        public IActionResult SignOut(int id)
        {
            var userId = this.userManager.GetUserId(User);
            var success = this.courses.SignOutUser(id, userId);

            if (!success)
            {
                return BadRequest();
            }

            TempData.AddSuccessMessage("Sorry to see you go.");
            return RedirectToAction(nameof(Details), new { id });
        }
    }
}