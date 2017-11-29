using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using AutoMapper;
using LearningSystem.Common.Mapping;
using LearningSystem.Data.Models;

namespace LearningSystem.Services.Blog.Models
{
    public class BlogArticleDetailsSM : IMapFrom<Article>
    {
        public int Id { get; set; }        
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }
        public string Author { get; set; }

        public void ConfigureMapping(Profile mapper)
            => mapper
            .CreateMap<Article, BlogArticleDetailsSM>()
            .ForMember(a => a.Author, cfg => cfg.MapFrom(a => a.Author.UserName));
    }
}
