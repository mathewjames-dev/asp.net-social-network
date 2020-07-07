using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Data;
using SocialNetwork.Models.Users.Status;
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

        [HttpPost]
        public string FaveStatus(string UserId, int PostId)
        {
            if (ModelState.IsValid)
            {
                PostLike postLike = new PostLike();
                postLike.UserId = UserId;
                postLike.PostId = PostId;
                _db.PostLikes.Add(postLike);
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
