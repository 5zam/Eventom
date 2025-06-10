using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Eventom.Models.User;

namespace Eventom.Models.Event
{
    public class Applications
    {
        [Key]
        public int ApplicationID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string? Status { get; set; }
        public string? MotivationStatement { get; set; }
        public string? RelevantExperience { get; set; }
        public DateTime DecisionDate { get; set; }
        public string? DecisionReason { get; set; }



        public string? VolunteerID { get; set; }
        [ForeignKey("VolunteerID")]
        public ApplicationUser? Volunteer { get; set; }


        public int CommitteeID { get; set; }
        [ForeignKey("CommitteeID")]
        public Committees? Committee { get; set; }


    }
}
