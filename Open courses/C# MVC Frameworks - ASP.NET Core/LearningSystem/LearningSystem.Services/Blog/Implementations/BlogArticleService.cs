namespace LearningSystem.Services.Blog.Implementations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper.QueryableExtensions;
    using LearningSystem.Data;
    using LearningSystem.Data.Models;
    using LearningSystem.Services.Blog.Models;

    using static LearningSystem.Services.ServiceConstants;

    public class BlogArticleService : IBlogArticleService
    {
        private readonly LearningSystemDbContext db;

        public BlogArticleService(LearningSystemDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<BlogArticleListingSM> All(int page = 1)
        {
            return this.db
                .Articles
                .OrderByDescending(a => a.PublishDate)
                .Skip((page - 1) * BlogArticlesPageSize)
                .Take(BlogArticlesPageSize)
                .ProjectTo<BlogArticleListingSM>()
                .ToList();
        }

        public BlogArticleDetailsSM ById(int id)
        {
            return this.db
                .Articles
                .Where(a => a.Id == id)
                .ProjectTo<BlogArticleDetailsSM>()
                .FirstOrDefault();
        }

        public void Create(string title, string content, string authorId)
        {
            var article = new Article
            {
                Title = title,
                Content = content,
                PublishDate = DateTime.UtcNow,
                AuthorId = authorId
            };

            this.db.Add(article);
            this.db.SaveChanges();
        }

        public int Total()
        {
            return this.db.Articles.Count();
        }
    }
}
