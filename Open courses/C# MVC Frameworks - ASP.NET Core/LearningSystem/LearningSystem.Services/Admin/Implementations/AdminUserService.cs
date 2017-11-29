namespace LearningSystem.Services.Admin.Implementations
{
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper.QueryableExtensions;
    using LearningSystem.Data;
    using LearningSystem.Services.Admin.Models;

    public class AdminUserService : IAdminUserService
    {
        private readonly LearningSystemDbContext db;

        public AdminUserService(LearningSystemDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<AdminUserListingSM> All()
        {
            return this.db
                .Users
                .ProjectTo<AdminUserListingSM>()
                .ToList();
        }
    }
}
