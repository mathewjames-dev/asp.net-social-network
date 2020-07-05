using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.Classes.Hubs;
using SocialNetwork.Data;
using SocialNetwork.Models.Users;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SocialNetwork.Controllers
{
    [Authorize]
    public class FriendController : Controller
    {
        /*
         * We want to setup a _db variable which will be an instance of the DB context.
         */
        private readonly ApplicationDbContext _db;

        /*
         * Set an instance of IHubContext utilizing GlobalHub and set to a variable.
         */
        private readonly IHubContext<GlobalHub> _globalHubContext;

        /*
         * Setting up an instance of the user manager.
         */
        private readonly UserManager<ApplicationUser> _userManager;


        /*
         * Constructor method for the controller
         */

        public FriendController(ApplicationDbContext db, IHubContext<GlobalHub> globalHubContext, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _globalHubContext = globalHubContext;
            _userManager = userManager;
        }

        /*
         * Method to create a status for the given user
         */
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddFriend([Bind(include: "FriendId, UserId")] ApplicationUserFriend applicationUserFriend)
        {
            // Check to see if the model is valid
            if (ModelState.IsValid)
            {
                // Add the record to the database if it is valid.
                _db.UserFriends.Add(applicationUserFriend);

                await _db.SaveChangesAsync();
            }

            // Then redirect the user back to the Index function
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> RemoveFriend([Bind(include: "FriendId, UserId")] ApplicationUserFriend applicationUserFriend)
        {
            if (ModelState.IsValid)
            {
                // Delete the record from the database if the model is valid, after we get the record.
                ApplicationUserFriend applicationUserFriendRecord = await _db.UserFriends.FirstOrDefaultAsync(m => m.UserId == applicationUserFriend.UserId && m.FriendId == applicationUserFriend.FriendId);

                _db.UserFriends.Remove(applicationUserFriendRecord);

                await _db.SaveChangesAsync();
            }

            // Then redirect the user back to the Index function
            return RedirectToAction("Index", "Home");
        }
    }
}