using SocialNetwork.Data;
using SocialNetwork.Models.Users.Status;
using System.Collections.Generic;
using System.Linq;

namespace SocialNetwork.Classes.Users.Timeline
{
    public class Timeline
    {
        // Set the private class variables.
        private readonly ApplicationDbContext _db;

        public Timeline()
        {}

        public Timeline(ApplicationDbContext db)
        {
            _db = db;
        }

        public List<Post> BuildHomeTimeline(string userId)
        {
            List<Post> posts = _db.Posts.Where(m => m.UserId == userId).ToList();
            return posts;
        }
    }
}
