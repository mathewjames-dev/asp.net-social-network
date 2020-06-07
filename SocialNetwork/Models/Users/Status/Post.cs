using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public ApplicationUser User
        {
            get;
            set;
        }
    }
}
