using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Xml;
using FeedService.Entity;
using FeedService.Extension;
using FeedService.Repository;

namespace FeedService.Service
{
    public class FeedService
    {

        private readonly ElasticRepository _repository;

        public FeedService()
        {
            _repository = new ElasticRepository();
        }

        public void SyncNewFeeds()
        {

            var feedReader = XmlReader.Create("http://lifehacker.com/rss");

            var channel = SyndicationFeed.Load(feedReader);

            if (channel == null)
                throw new ArgumentException("Can't sync feeds from url");

            foreach (var feed in channel.Items)
            {
                _repository.InsertFeed(feed.ToFeedEntity());
            }





        }

        public IEnumerable<FeedEntity> SearchFeed(string searchString)
        {
             return _repository.FullTextSearch(searchString);
        }



    }


}
