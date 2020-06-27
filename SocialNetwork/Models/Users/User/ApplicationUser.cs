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
        /*
         * We want to setup a _db variable which will be an instance of the DB context.
         */
        private readonly ApplicationDbContext _db;

        /*
         * Constructor methods
         */
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
        [PersonalData]
        public ICollection<Post> Posts
        {
            get;
            set;
        }

        // Friend Requests Relationship
        public ICollection<ApplicationUserFriendRequest> UserFriendRequests
        {
            get;
            set;
        }

        // Friends Relationship
        public ICollection<ApplicationUserFriend> UserFriends
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
    }
}
