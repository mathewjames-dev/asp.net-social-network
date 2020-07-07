using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialNetwork.Models.Users.Status
{
    [Table("PostLikes")]
    public class PostLike
    {
        public PostLike()
        { }

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        // Basic Id Column
        public int Id
        {
            get;
            set;
        }

        public string UserId
        {
            get;
            set;
        }

        public int PostId
        {
            get;
            set;
        }

        public virtual ApplicationUser User { get; set; }

        public virtual Post post { get; set; }
    }
}
