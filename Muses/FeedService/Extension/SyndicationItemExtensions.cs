using System.ServiceModel.Syndication;
using FeedService.Entity;

namespace FeedService.Extension
{
    public static class SyndicationItemExtensions
    {
        public static FeedEntity ToFeedEntity(this SyndicationItem item)
        {
            var newFeed = new FeedEntity
            {
                Title = item.Title.Text,

            };
            
            ExtractFeedContent(item,newFeed);
            
            return newFeed;
        }

        private static void ExtractFeedContent(SyndicationItem item,FeedEntity newFeed )
        {
            
            if (item.Content != null)
            {
                var textContent = item.Content as TextSyndicationContent;

                if (textContent != null)
                {
                    newFeed.Content = textContent.Text;
                }
            }
            else
            {
                newFeed.Content = item.Summary.Text;
            }
        }
    }
}