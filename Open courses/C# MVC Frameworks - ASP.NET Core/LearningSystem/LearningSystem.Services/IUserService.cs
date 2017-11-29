using System;
using System.Collections.Generic;
using System.Text;
using LearningSystem.Services.Models.Users;

namespace LearningSystem.Services
{
    public interface IUserService
    {
        UserProfileSM Profile(string id);
    }
}
