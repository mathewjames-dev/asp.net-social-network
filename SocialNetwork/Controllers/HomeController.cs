using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Classes.Users.Timeline;
using SocialNetwork.Data;
using SocialNetwork.Models;
using SocialNetwork.Models.Users;
using SocialNetwork.Models.ViewModels;

namespace SocialNetwork.Controllers
{
    /*
     * Making the entire controller only accessible to authorized users.
     */
    [Authorize]
    public class HomeController : Controller
    {
        // Setting the private variables that we will utilize in the controller.
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly TimelineService _timeLine;

        public HomeController(UserManager<ApplicationUser> userManager,
            TimelineService timeLine)
        {
            // Injecting the classes into the controller and assigning to variables.
           this. _userManager = userManager;
           this._timeLine = timeLine;
        }

        /*
         * GET /
         */
        public async Task<IActionResult> Index()
        {
            // Get the logged in users UserId.
            string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            // Utilize the userId to get an application user instance of the logged in user.
            ApplicationUser applicationUser = await _userManager.FindByIdAsync(userId);

            // Create an instance of the ViewModel and assign it to a variable.
            var homeViewModel = new HomeViewModel
            {
                User = applicationUser,
                FriendSuggestions = applicationUser.GetTopFiveFriendSuggestions(),
                TimelinePosts = _timeLine.BuildHomeTimeline(userId)
            };

            return View(homeViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
