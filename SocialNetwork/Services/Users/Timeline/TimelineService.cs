using SocialNetwork.Data;
using SocialNetwork.Models.Users.Status;
using System.Collections.Generic;
using System.Linq;

namespace SocialNetwork.Classes.Users.Timeline
{
    public class TimelineService
    {
        // Setting the private variables.
        private readonly Timeline _timeline;

        public TimelineService()
        {}

        // Constructor for the service
        public TimelineService(Timeline timeline)
        {
            _timeline = timeline;
        }

        // Build the home timeline.
        public List<Post> BuildHomeTimeline(string userId)
        {
            return _timeline.BuildHomeTimeline(userId);
        }

        // Build post likes html.
        public string BuildPostLikesHtml(int postId)
        {
            return _timeline.BuildPostLikesHtml(postId);
        }
    }
}
