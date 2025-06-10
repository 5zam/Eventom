using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Eventom.Models.User;

namespace Eventom.Models.Event
{
    public class Events
    {
        [Key]
        public int EventID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public string? Location { get; set; }
        public string? City { get; set; }
        public DateTime RegistrationDeadline { get; set; }
        public string? Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }





        public string? CreatorID { get; set; }
        [ForeignKey("CreatorID")]
        public ApplicationUser? EventCreator { get; set; }


        //mean that Event can have one Category
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }
        
        public ICollection<Committees> Committees { get; set; } = new List<Committees>();

    }
}
