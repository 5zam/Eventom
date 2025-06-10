using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Eventom.Models.User
{
    public class Notification
    {
        [Key]
        public int NotificationID { get; set; }

        public string Message { get; set; }           
        public bool IsRead { get; set; } = false;      
        public DateTime CreatedAt { get; set; } = DateTime.Now;

       
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
    }
}
