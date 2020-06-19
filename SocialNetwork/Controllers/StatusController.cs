using System;
using System.Diagnostics;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using SocialNetwork.Classes.Hubs;
using SocialNetwork.Data;
using SocialNetwork.Models.ViewModels;

namespace SocialNetwork.Controllers
{
    [Authorize]
    public class StatusController : Controller
    {
        private readonly ILogger<StatusController> _logger;

        /*
         * We want to setup a _db variable which will be an instance of the DB context.
         */
        private readonly ApplicationDbContext _db;

        /*
         * Set an instance of IHubContext utilizing GlobalHub and set to a variable. 
         */
        private readonly IHubContext<GlobalHub> _globalHubContext;

        public StatusController(ILogger<StatusController> logger, ApplicationDbContext db, IHubContext<GlobalHub> globalHubContext)
        {
            _logger = logger;
            _db = db;
            _globalHubContext = globalHubContext;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> StatusPost(HomeViewModel viewModel)
        {
            /*
             * Add the post data from the view model into the posts table as a new record
             */
            viewModel.Post.UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            _db.Posts.Add(viewModel.Post);

            /*
             * Update the database changes
             */
            await _db.SaveChangesAsync();

            /*
             * Send the user id and post content to the global hub method broadcast message
             */
            await _globalHubContext.Clients.All.SendAsync("BroadcastMessage", viewModel.Post.UserId, viewModel.Post.Content);


            /*
             * Then redirect the user back to the Index function
             */
            return RedirectToAction("Index", "Home");
        }
    }
}
