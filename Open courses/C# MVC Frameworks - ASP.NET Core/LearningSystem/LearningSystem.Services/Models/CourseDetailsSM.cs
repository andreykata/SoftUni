namespace LearningSystem.Services.Models
{
    using System;
    using AutoMapper;
    using LearningSystem.Common.Mapping;
    using LearningSystem.Data.Models;

    public class CourseDetailsSM : IMapFrom<Course>, IHaveCustomMapping
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string TrainerName { get; set; }
        public int StudentsCount { get; set; }

        public void ConfigureMapping(Profile mapper)
            => mapper
            .CreateMap<Course, CourseDetailsSM>()
            .ForMember(c => c.TrainerName, cfg => cfg.MapFrom(c => c.Trainer.UserName))
            .ForMember(c => c.StudentsCount, cfg => cfg.MapFrom(c => c.Students.Count));
    }
}
