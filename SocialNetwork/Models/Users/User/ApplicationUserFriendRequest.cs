using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using SocialNetwork.Models.Users.Status;
using System.Security.Claims;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.Models.Users
{
    [Table("UserFriendRequests")]
    public class ApplicationUserFriendRequest
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Accepted { get; set; }

        public string FriendId { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
