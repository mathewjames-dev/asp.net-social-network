using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using SocialNetwork.Models.Users.Status;

namespace SocialNetwork.Models.Users
{
    public class ApplicationUser : IdentityUser
    {

        public ICollection<Post> Posts
        {
            get;
            set;
        }
    }
}
