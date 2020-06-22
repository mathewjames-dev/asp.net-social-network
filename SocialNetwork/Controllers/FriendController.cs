using System;
using System.Diagnostics;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SocialNetwork.Classes.Hubs;
using SocialNetwork.Data;
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
         * Constructor method for the controller
         */
        public FriendController(ApplicationDbContext db, IHubContext<GlobalHub> globalHubContext)
        {
            _db = db;
            _globalHubContext = globalHubContext;
        }

        /*
         * Method to create a status for the given user
         */
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddFriend(HomeViewModel viewModel)
        {
            /*
             * Then redirect the user back to the Index function
             */
            return RedirectToAction("Index", "Home");
        }
    }
}
