﻿namespace LearningSystem.Web.Infrastructure.Extensions
{
    using Microsoft.AspNetCore.Mvc;

    public static class ControlleExtensions
    {
        public static IActionResult ViewOrNotFound(this Controller controller, object model)
        {
            if (model == null)
            {
                return controller.NotFound();
            }

            return controller.View(model);
        }
    }
}
