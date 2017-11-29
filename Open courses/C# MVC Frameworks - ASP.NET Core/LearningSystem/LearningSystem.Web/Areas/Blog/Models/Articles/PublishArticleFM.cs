namespace LearningSystem.Web.Areas.Blog.Models.Articles
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using static LearningSystem.Data.DataConstants;

    public class PublishArticleFM
    {
        [Required]
        [MinLength(ArticleTitleMinLength)]
        [MaxLength(ArticleTitleMaxLength)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }
    }
}
