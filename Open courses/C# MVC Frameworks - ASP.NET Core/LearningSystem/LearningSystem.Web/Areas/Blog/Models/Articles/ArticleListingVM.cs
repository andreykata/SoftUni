namespace LearningSystem.Web.Areas.Blog.Models.Articles
{
    using System;
    using System.Collections.Generic;
    using LearningSystem.Services.Blog.Models;

    using static LearningSystem.Services.ServiceConstants;

    public class ArticleListingVM
    {
        public IEnumerable<BlogArticleListingSM> Articles { get; set; }
        public int TotalArticles { get; set; }
        public int TotalPages => (int)Math.Ceiling((double)this.TotalArticles / BlogArticlesPageSize);
        public int CurrentPage { get; set; }
        public int PreviousPage => this.CurrentPage == 1 ? 1 : this.CurrentPage - 1;
        public int NextPage => this.CurrentPage == this.TotalPages ? this.TotalPages : this.CurrentPage + 1;
    }
}
