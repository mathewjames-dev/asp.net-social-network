using Microsoft.AspNetCore.Identity;
using SocialNetwork.Models.Users;
using SocialNetwork.Models.Users.Status;
using System;
using System.Collections;

namespace SocialNetwork.Models.ViewModels
{
    public class HomeViewModel
    {
        /*
         * We want to access the post model when on the home page.
         * First reason we will need to do this is for the status form.
         */
        public Post Post 
        { 
            get;
            set;
        }

        public ApplicationUser User
        {
            get;
            set;
        }
    }
}
