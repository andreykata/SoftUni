using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSystem.Services.Admin
{
    public interface IAdminCourseService
    {
        void Create(string name, string description, DateTime startDate, DateTime endData, string trainerId);
    }
}
