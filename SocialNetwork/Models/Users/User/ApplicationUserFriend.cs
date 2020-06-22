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
    [Table("UserFriends")]
    public class ApplicationUserFriend
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int RelationId { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public string FriendId { get; set; }

        public ApplicationUser Friend { get; set; }
    }
}
