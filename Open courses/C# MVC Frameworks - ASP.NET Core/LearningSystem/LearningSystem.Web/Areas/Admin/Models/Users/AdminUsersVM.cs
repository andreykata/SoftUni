namespace LearningSystem.Web.Areas.Admin.Models.Users
{
    using System.Collections.Generic;
    using LearningSystem.Services.Admin.Models;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class AdminUsersVM
    {
        public IEnumerable<SelectListItem> Roles { get; set; }
        public IEnumerable<AdminUserListingSM> Users { get; set; }
    }
}
