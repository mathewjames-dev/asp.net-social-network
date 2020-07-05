using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using SocialNetwork.Models.Users.Status;
using System.Security.Claims;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using SocialNetwork.Data;
using System.Linq;
using System.Diagnostics;

namespace SocialNetwork.Models.Users
{
    public class ApplicationUser : IdentityUser
    {
        // We want to setup a _db variable which will be an instance of the DB context.
        private readonly ApplicationDbContext _db;

        // Constructor methods
        public ApplicationUser()
        { }
        public ApplicationUser(ApplicationDbContext db)
        {
            _db = db;
        }

        // Profile Photo Column
        public string ProfilePhoto
        {
            get;
            set;
        }

        // First Name Column
        [PersonalData]
        public string FirstName
        {
            get;
            set;
        }

        // Last Name Column
        [PersonalData]
        public string LastName
        {
            get;
            set;
        }

        // Posts Relationship
        public virtual ICollection<Post> Posts
        {
            get;
            set;
        }

        // Friends Relationship
        public virtual ICollection<ApplicationUserFriend> UserFriends
        {
            get;
            set;
        }

        // Friend Requests Relationship
        public virtual ICollection<ApplicationUserFriendRequest> UserFriendRequests
        {
            get;
            set;
        }

        public bool IsFriend(string userId, string friendId)
        {
            if (userId == null || friendId == null)
            {
                return false;
            }

            var applicationUserFriend = _db.UserFriends.Where(m => m.UserId == userId && m.FriendId == friendId).FirstOrDefault();

            return applicationUserFriend != null;
        }

        public IList<ApplicationUser> GetTopFiveFriendSuggestions()
        {
            return _db.Users.Where(m => m.Id != this.Id).Take(5).ToList();
        }
    }
}
