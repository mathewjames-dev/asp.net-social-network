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
    public class StatusController : Controller
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
        public StatusController(ApplicationDbContext db, IHubContext<GlobalHub> globalHubContext)
        {
            this._db = db;
            this._globalHubContext = globalHubContext;
        }

        /*
         * Method to create a status for the given user
         */
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

        /*
         * Method to delete a status for the given user
         */
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> StatusDelete(int? StatusId)
        {
            /*
             * If no status id was passed we will return the 404 page.
             */
            if(StatusId == null)
            {
                return NotFound();
            }

            /*
             * We will try to get the post into the post model.
             */
            Post post = await _db.Posts.FirstOrDefaultAsync(m => m.StatusId == StatusId);

            /*
             * Once we get the post we can then remove it from the database.
             */
            _db.Posts.Remove(post);

            /*
             * Finally update the database and redirect to the homepage.
             */
            await _db.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
