namespace LearningSystem.Services.Admin
{
    using System.Collections.Generic;
    using LearningSystem.Services.Admin.Models;

    public interface IAdminUserService
    {
        IEnumerable<AdminUserListingSM> All();
    }
}
