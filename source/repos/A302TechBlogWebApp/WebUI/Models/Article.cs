using System.ComponentModel.DataAnnotations;

namespace WebUI.Models
{
    public class Article
    {
        //Solid
        //Single Responsibility
        public int Id { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        public string Title { get; set; }
        public string Content { get; set; }
        public string PhotoUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public int ViewCount { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<ArticleTag> ArticleTag { get; set; }
        public bool IsActive { get; set; }
        public bool isFeatured { get; set; }
        public bool IsDeleted { get; set; }
        public string SeoUrl { get; set; }
    }
}
