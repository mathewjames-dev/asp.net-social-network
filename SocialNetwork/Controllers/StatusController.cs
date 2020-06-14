using System;
using System.Diagnostics;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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

        public StatusController(ILogger<StatusController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
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
             * Then redirect the user back to the Index function
             */
            return RedirectToAction("Index", "Home");
        }
    }
}
