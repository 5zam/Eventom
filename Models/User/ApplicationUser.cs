using Eventom.Models.Event;
using Eventom.Models.User.Enums;
using Microsoft.AspNetCore.Identity;

namespace Eventom.Models.User
{
    public class ApplicationUser : IdentityUser
    {
        //for all users
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string? City { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastLoginDate { get; set; }

        
        public UserTypes UserType { get; set; }

        // only if UserType is Volunteer
        public string? EducationLevel { get; set; }
        public string? Skills { get; set; }
        public string? Interests { get; set; }
        public string? PreviousExperience { get; set; }
        public int? TotalEventsParticipated { get; set; }
        public double? AverageRating { get; set; }
        public string? VolunteerLevel { get; set; }



       
        public ICollection<Events> CreatedEvents { get; set; } = new List<Events>();

       
        public ICollection<Committees> Leader { get; set; } = new List<Committees>();


    }
}
