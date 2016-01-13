using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using FeedService.Entity;
using Nest;

namespace FeedService.Repository
{
    public class ElasticRepository
    {
        private readonly ElasticClient _client;

        public ElasticRepository()
        {
            //TODO get From Config

            var node = new Uri("http://localhost:9200");

            var settings = new ConnectionSettings(node, "feed");

            _client = new ElasticClient(settings);
        }

        public void InsertFeed(FeedEntity feed)
        {
            var result = _client.Index(feed);
            if (!result.Created)
                throw new DataException("Can't Insert Data");

        }

        public IEnumerable<FeedEntity> FullTextSearch(string searchString)
        {
            var queryResult =  _client.Search<FeedEntity>(t => t.AllIndices().AllTypes().QueryString(searchString));
            return queryResult.Hits.Select(t => t.Source);
        }

    }
}