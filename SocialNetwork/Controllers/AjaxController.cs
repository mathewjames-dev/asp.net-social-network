using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SocialNetwork.Classes.Users.Timeline;
using SocialNetwork.Data;
using SocialNetwork.Models.Users.Status;
using SocialNetwork.Models.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Controllers
{
    [Authorize]
    public class AjaxController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly TimelineService _timeLine;

        public AjaxController(ApplicationDbContext db, TimelineService timeLine)
        {
            this._db = db;
            this._timeLine = timeLine;
        }

        // Utilized to like a users post.
        [HttpPost]
        public JsonResult LikePost(string UserId, int PostId)
        {
            AjaxPostLikedViewModel postLikedViewModel = new AjaxPostLikedViewModel();

            if (ModelState.IsValid)
            {
                PostLike postLike = new PostLike
                {
                    UserId = UserId,
                    PostId = PostId
                };
                _db.PostLikes.Add(postLike);
                _db.SaveChanges();

                postLikedViewModel.Response = "Success";
                postLikedViewModel.LikesHtml = _timeLine.BuildPostLikesHtml(PostId);
                return Json(postLikedViewModel);
            }
            else
            {
                postLikedViewModel.Response = "Failed";
                return Json(postLikedViewModel);
            }
        }

        // Utilized to unlike a users post.
        [HttpPost]
        public JsonResult UnlikePost(string UserId, int PostId)
        {
            AjaxPostLikedViewModel postLikedViewModel = new AjaxPostLikedViewModel();
            if (ModelState.IsValid)
            {
                PostLike postLike = _db.PostLikes.Where(m => m.UserId == UserId && m.PostId == PostId).FirstOrDefault();
                _db.PostLikes.Remove(postLike);
                _db.SaveChanges();

                postLikedViewModel.Response = "Success";
                postLikedViewModel.LikesHtml = _timeLine.BuildPostLikesHtml(PostId);
                return Json(postLikedViewModel);
            }
            else
            {
                postLikedViewModel.Response = "Failed";
                return Json(postLikedViewModel);
            }
        }
    }
}
