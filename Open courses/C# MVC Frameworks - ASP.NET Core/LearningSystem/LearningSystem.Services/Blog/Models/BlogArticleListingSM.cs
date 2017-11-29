namespace LearningSystem.Services.Blog.Models
{
    using System;
    using AutoMapper;
    using LearningSystem.Common.Mapping;
    using LearningSystem.Data.Models;

    public class BlogArticleListingSM : IMapFrom<Article>
    {
        public int Id { get; set; }        
        public string Title { get; set; }                
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }
        public string Author { get; set; }

        public void ConfigureMapping(Profile mapper)
            => mapper
                .CreateMap<Article, BlogArticleListingSM>()
                .ForMember(a => a.Author, cfg => cfg.MapFrom(a => a.Author.UserName));
    }
}
