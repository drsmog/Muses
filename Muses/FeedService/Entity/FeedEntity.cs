using System.Collections.Generic;

namespace FeedService.Entity
{
    public class FeedEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public List<string> CategoryList { get; set; }
        public List<string> AuthorList { get; set; }


    }
}