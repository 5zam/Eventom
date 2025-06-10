using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Eventom.Models.User;

namespace Eventom.Models.Event
{
    public class Committees
    {
        [Key]
        public int CommitteeID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? RequiredVolunteers { get; set; }
        public string? RequiredSkills { get; set; }



        [ForeignKey("LeaderID")] //volunteer id 
        public ApplicationUser? Leader { get; set; }
        public string? LeaderID { get; set; }



        [ForeignKey("EventID")]
        public Events? Event { get; set; }
        public int EventID { get; set; }


        
    }
}
