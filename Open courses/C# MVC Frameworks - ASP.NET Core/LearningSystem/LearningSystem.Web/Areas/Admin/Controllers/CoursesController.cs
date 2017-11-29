using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningSystem.Data.Models;
using LearningSystem.Services.Admin;
using LearningSystem.Web.Areas.Admin.Models.Courses;
using LearningSystem.Web.Controllers;
using LearningSystem.Web.Infrastructure.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LearningSystem.Web.Areas.Admin.Controllers
{
    public class CoursesController : BaseAdminController
    {
        private readonly IAdminCourseService courses;
        private readonly UserManager<User> userManager;

        public CoursesController(UserManager<User> userManager, IAdminCourseService courses)
        {
            this.courses = courses;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Create()
        {
            return View(new AddCourseFM
            {
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(30),
                Trainers = await GetTrainers()
            });
        }
        
        [HttpPost]
        public async Task<IActionResult> Create(AddCourseFM model)
        {
            if (!ModelState.IsValid)
            {
                return View(new AddCourseFM
                {
                    StartDate = DateTime.UtcNow,
                    EndDate = DateTime.UtcNow.AddDays(30),
                    Trainers = await GetTrainers()
                });
            }

            this.courses.Create(model.Name, model.Description, model.StartDate, model.EndDate, model.TrainerId);

            TempData.AddSuccessMessage($"Course {model.Name} created successully");

            return RedirectToAction(nameof(HomeController.Index), "Home", new { area = string.Empty });
        }

        private async Task<List<SelectListItem>> GetTrainers()
        {
            var trainers = await this.userManager.GetUsersInRoleAsync(WebConstants.TrainerRole);

            var trainerListItems = trainers
                .Select(t => new SelectListItem
                {
                    Text = t.UserName,
                    Value = t.Id
                })
                .ToList();
            return trainerListItems;
        }
    }
}