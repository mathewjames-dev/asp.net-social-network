using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Data;
using SocialNetwork.Models.Users.Status;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Controllers
{
    [Authorize]
    public class AjaxController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AjaxController(ApplicationDbContext db)
        {
            this._db = db;
        }

        // Utilized to like a users post.
        [HttpPost]
        public string LikePost(string UserId, int PostId)
        {
            if (ModelState.IsValid)
            {
                PostLike postLike = new PostLike
                {
                    UserId = UserId,
                    PostId = PostId
                };
                _db.PostLikes.Add(postLike);
                _db.SaveChanges();

                return "Success";
            }
            else
            {
                return "Failed";
            }
        }

        // Utilized to unlike a users post.
        [HttpPost]
        public string UnlikePost(string UserId, int PostId)
        {
            if (ModelState.IsValid)
            {
                PostLike postLike = _db.PostLikes.Where(m => m.UserId == UserId && m.PostId == PostId).FirstOrDefault();
                _db.PostLikes.Remove(postLike);
                _db.SaveChanges();

                return "Success";
            }
            else
            {
                return "Failed";
            }
        }
    }
}
