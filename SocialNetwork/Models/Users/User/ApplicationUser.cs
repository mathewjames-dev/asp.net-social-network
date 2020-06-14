using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using SocialNetwork.Models.Users.Status;
using System.Security.Claims;
using System.Threading.Tasks;

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
        public IList<Post> Posts
        {
            get;
            set;
        }
    }
}
