using Microsoft.AspNetCore.Identity;
using SocialNetwork.Models.Users;
using SocialNetwork.Models.Users.Status;
using System;
using System.Collections;
using System.Collections.Generic;

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

        /*
         * This is just passing the user model to the front end
         */
        public ApplicationUser User
        {
            get;
            set;
        }

        /*
         * We want to get a list of friend suggestions
         */
        public IList<ApplicationUser> FriendSuggestions
        {
            get;
            set;
        }
    }
}
