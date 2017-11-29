namespace LearningSystem.Services.Blog
{
    using System.Collections.Generic;
    using LearningSystem.Services.Blog.Models;

    public interface IBlogArticleService
    {
        IEnumerable<BlogArticleListingSM> All(int page = 1);
        BlogArticleDetailsSM ById(int id);
        int Total();
        void Create(string title, string content, string authorId);
    }
}
