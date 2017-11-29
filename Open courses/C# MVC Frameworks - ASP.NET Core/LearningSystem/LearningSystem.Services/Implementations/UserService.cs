namespace LearningSystem.Services.Implementations
{
    using System.Linq;
    using AutoMapper.QueryableExtensions;
    using LearningSystem.Data;
    using LearningSystem.Services.Models.Users;

    public class UserService : IUserService
    {
        private readonly LearningSystemDbContext db;

        public UserService(LearningSystemDbContext db)
        {
            this.db = db;
        }

        public UserProfileSM Profile(string id)
        {
            return this.db
                .Users
                .Where(u => u.Id == id)
                .ProjectTo<UserProfileSM>(new { studentId = id })
                .FirstOrDefault();
        }
    }
}
