using System.Web.Http;
using FdService = FeedService.Service.FeedService;

namespace Muses.WebApi.Controllers
{
    public class FeedController : ApiController
    {
        private readonly FdService _feedService;

        public FeedController()
        {
            _feedService = new FdService();
        }

        public IHttpActionResult GetNewFeeds(string searchString)
        {
            return Ok(_feedService.SearchFeed(searchString));
        }
    }
}