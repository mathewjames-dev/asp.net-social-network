using Microsoft.AspNetCore.Identity;
using SocialNetwork.Models.Users;
using SocialNetwork.Models.Users.Status;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SocialNetwork.Models.ViewModels
{
    public class AjaxPostLikedViewModel
    {
        public string Response
        {
            get;
            set;
        }

        public string LikesHtml
        {
            get;
            set;
        }
    }
}
