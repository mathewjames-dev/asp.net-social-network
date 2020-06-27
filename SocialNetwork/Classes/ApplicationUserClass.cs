using Microsoft.AspNetCore.Identity;
using SocialNetwork.Data;
using SocialNetwork.Models.Users;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SocialNetwork.Classes
{
    public static class ApplicationUserClass
    {
        /*
        * We want to setup a _db variable which will be an instance of the DB context.
        */
        private static readonly ApplicationDbContext _db;

        public static bool IsFriend(string userId, string friendId)
        {
            if (userId == null || friendId == null)
            {
                return false;
            }
            Debug.WriteLine(userId);
            Debug.WriteLine(friendId);
            Debug.WriteLine(_db);
            var applicationUserFriend = _db.UserFriends.Where(m => m.UserId == userId && m.FriendId == friendId).FirstOrDefault();

            return applicationUserFriend != null;
        }
    }
}
