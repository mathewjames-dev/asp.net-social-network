using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using SocialNetwork.Models.Users.Status;
using System.Security.Claims;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialNetwork.Models.Users
{
    public class ApplicationUser : IdentityUser
    {
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
        public virtual ICollection<Post> Posts
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

        // Friends Relationship
        public virtual ICollection<ApplicationUserFriend> UserFriends
        {
            get;
            set;
        }
    }
}
