using NUnit.Framework;

namespace FeedService.IntegrationTests
{
    [TestFixture]
    public class FeedServiceTest
    {
        [Test]
        [Ignore]
        public void SyncNewFeeds_CheckInsert()
        {
            var feedService = new Service.FeedService();

            feedService.SyncNewFeeds();

            Assert.True(true);

        }


        [Test]
        public void FullTextSearch_CheckFullTextSearch()
        {
            var feedService = new Service.FeedService();

            feedService.SearchFeed("sdf");

            Assert.True(true);

        }



    }
}