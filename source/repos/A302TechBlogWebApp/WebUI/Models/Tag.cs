﻿namespace WebUI.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string TagName { get; set; }
        public List<ArticleTag> ArticleTag { get; set; }

    }
}
