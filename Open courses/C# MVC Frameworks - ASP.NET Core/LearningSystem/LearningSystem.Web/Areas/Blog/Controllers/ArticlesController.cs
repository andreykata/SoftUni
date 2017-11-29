namespace LearningSystem.Web.Areas.Blog.Controllers
{
    using Ganss.XSS;
    using LearningSystem.Data.Models;
    using LearningSystem.Services.Blog;
    using LearningSystem.Services.Html;
    using LearningSystem.Web.Areas.Blog.Models.Articles;
    using LearningSystem.Web.Infrastructure.Extensions;
    using LearningSystem.Web.Infrastructure.Filters;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    using static LearningSystem.Web.WebConstants;

    [Area(BlogArea)]
    [Authorize(Roles = BlogAuthorRole)]
    public class ArticlesController : Controller
    {
        private readonly IBlogArticleService articles;
        private readonly UserManager<User> userManager;
        private readonly IHtmlService html;

        public ArticlesController(IBlogArticleService articles, UserManager<User> userManager, IHtmlService html)
        {
            this.articles = articles;
            this.userManager = userManager;
            this.html = html;
        }

        [AllowAnonymous]
        public IActionResult Index(int page = 1)
        {
            var allArticles = new ArticleListingVM
            {
                Articles = this.articles.All(page),
                TotalArticles = this.articles.Total(),
                CurrentPage = page
            };

            return this.View(allArticles);
        }

        [AllowAnonymous]
        public IActionResult Details(int id)
        {
            return this.ViewOrNotFound(this.articles.ById(id));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateModelState]
        public IActionResult Create(PublishArticleFM model)
        {
            model.Content = html.Sanitize(model.Content);

            var userId = this.userManager.GetUserId(User);
            this.articles.Create(model.Title, model.Content, userId);

            return RedirectToAction(nameof(Index));
        }
    }

    
    
}