using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SocialNetwork.Models.Users.Status
{
    public class Post
    {
        [Key]
        // Basic Id Column
        public int StatusId
        {
            get;
            set;
        }

        // Status Content
        public string Content
        {
            get;
            set;
        }

        // Status Created Date
        public DateTime CreatedDate
        {
            get;
            set;
        }

        // Status Updated Date
        public DateTime UpdatedDate
        {
            get;
            set;
        }

        // Foreign Key for user.
        public string UserId
        {
            get;
            set;
        }

        // User relationship
        public ApplicationUser User
        {
            get;
            set;
        }
    }
}
