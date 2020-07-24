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

        // Post Likes Relationship
        public virtual ICollection<PostLike> PostLikes
        {
            get;
            set;
        }

        // Check to see if the user is friends with the friendId.
        public bool IsFriend(string userId, string friendId)
        {
            return UserFriends.Where(m => m.UserId == userId && m.FriendId == friendId).FirstOrDefault() != null;
        }

        // Check to see if the user has already liked the post.
        public bool PostLiked(string userId, int postId)
        {
            return PostLikes.Where(m => m.UserId == userId && m.PostId == postId).FirstOrDefault() != null;
        }

        // Returns a list of top 5 friend suggestions
        public IList<ApplicationUser> GetTopFiveFriendSuggestions()
        {
            return _db.Users.Where(m => m.Id != this.Id).Take(5).ToList();
        }
    }
}
