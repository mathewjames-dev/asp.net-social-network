using System;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SocialNetwork.Classes.Hubs;
using SocialNetwork.Data;
using SocialNetwork.Models.Users;
using SocialNetwork.Models.Users.Status;
using SocialNetwork.Models.ViewModels;

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
        public async Task<IActionResult> AddFriend(string userId, string friendId)
        {
            /*
             * Check to see if the model is valid
             */
            Debug.WriteLine(ModelState.IsValid);

            if (ModelState.IsValid)
            {
                /*
                 * Creating a application user instance and setting it to the logged in user.
                 */
               // ApplicationUser applicationUser = await _userManager.FindByIdAsync(userId);

                ApplicationUserFriend applicationUserFriend = new ApplicationUserFriend
                {
                    FriendId = friendId,
                    UserId = userId
                };

                _db.UserFriends.Add(applicationUserFriend);

                await _db.SaveChangesAsync();
            }

            /*
             * Then redirect the user back to the Index function
             */
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> RemoveFriend(string userId, string friendId)
        {
            /*
             * Check to see if the model is valid
             */
            Debug.WriteLine(ModelState.IsValid);

            if (ModelState.IsValid)
            {
                /*
                 * Creating a application user instance and setting it to the logged in user.
                 */
                // ApplicationUser applicationUser = await _userManager.FindByIdAsync(userId);

                ApplicationUserFriend applicationUserFriend = await _db.UserFriends.FirstOrDefaultAsync(m => m.UserId == userId && m.FriendId == friendId);

                _db.UserFriends.Remove(applicationUserFriend);

                await _db.SaveChangesAsync();
            }

            /*
             * Then redirect the user back to the Index function
             */
            return RedirectToAction("Index", "Home");
        }
    }
}
