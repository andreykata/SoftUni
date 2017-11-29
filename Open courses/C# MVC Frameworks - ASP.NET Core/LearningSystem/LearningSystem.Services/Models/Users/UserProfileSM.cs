namespace LearningSystem.Services.Models.Users
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using LearningSystem.Common.Mapping;
    using LearningSystem.Data.Models;

    public class UserProfileSM : IMapFrom<User>, IHaveCustomMapping
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }

        public IEnumerable<UserProfileCourseSM> Courses { get; set; }

        public void ConfigureMapping(Profile mapper)
        {
            mapper
                .CreateMap<User, UserProfileSM>()
                .ForMember(u => u.Courses, cfg => cfg.MapFrom(s => s.Courses.Select(c => c.Course)));
        }
    }
}
