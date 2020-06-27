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
        /*
         * We want to setup a _db variable which will be an instance of the DB context.
         */
        private readonly ApplicationDbContext _db;

        /*
         * Setting up an instance of the user manager.
         */
        private readonly UserManager<ApplicationUser> _userManager;

        /*
         * Constructor method for the home controller
         */
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
            /*
             * Utilizing claims to get the logged in users id.
             */
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            /*
             * Creating a application user instance and setting it to the logged in user.
             */
             ApplicationUser applicationUser = await _userManager.GetUserAsync(User);

            /* 
             * Setting the users posts to the posts we get from the database. Restricting it on userId.
             */
            applicationUser.Posts = _db.Posts.Where(m => m.UserId == userId).ToList();

            /*
             * Create an instance of the ViewModel and assign it to a variable.
             * Setting the logged in 
             */
            var homeViewModel = new HomeViewModel
            {
                User = applicationUser,
                FriendSuggestions = _db.Users.Where(m => m.Id != userId).Take(5).ToList()
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
