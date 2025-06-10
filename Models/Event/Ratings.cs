using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Eventom.Models.User;

namespace Eventom.Models.Event
{
    public class Ratings
    {
        [Key]
        public int RatingID { get; set; }
        public string? PunctualityRating { get; set; }
        public string? TeamworkRating { get; set; }
        public string? InitiativeRating { get; set; }
        public string? OverallRating { get; set; }
        public string? Feedback { get; set; }
        public DateTime RatingDate { get; set; }



        public int EventID { get; set; }
        [ForeignKey("EventID")]
        public Events? Event { get; set; }


        public string? VolunteerID { get; set; }
        [ForeignKey("VolunteerID")]
        public ApplicationUser? Volunteer { get; set; }


        public string? CreatorID { get; set; }
        [ForeignKey("CreatorID")]
        public ApplicationUser? Creator { get; set; }
    }
}
