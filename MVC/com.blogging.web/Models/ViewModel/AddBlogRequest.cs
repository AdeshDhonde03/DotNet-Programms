﻿namespace com.blogging.web.Models.ViewModel
{
    public class AddBlogRequest
    {
        public string Heading { get; set; }
        public string PageTitle { get; set; }
        public string Content { get; set; }
        public string ShortDescripton { get; set; }
        public string FeaturedImageUrl { get; set; }
        public string UrlHandle { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Author { get; set; }
        public bool Visible { get; set; }
    }
}
