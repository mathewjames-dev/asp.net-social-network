using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ApplicationDbContext db, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        /*
         * GET /
         */
        public async Task<IActionResult> Index()
        {
            // Set the ApplicationUserClass UserId.
            string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            // Get the logged in user.
            ApplicationUser applicationUser = await _userManager.FindByIdAsync(userId);
            Debug.WriteLine(applicationUser.Posts.Count);

            // Create an instance of the ViewModel and assign it to a variable.
            var homeViewModel = new HomeViewModel
            {
                User = applicationUser,
                FriendSuggestions = applicationUser.GetTopFiveFriendSuggestions()
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
