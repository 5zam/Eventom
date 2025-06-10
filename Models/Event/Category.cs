using System.ComponentModel.DataAnnotations;

namespace Eventom.Models.Event
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string? CategoryName { get; set; }

        public IEnumerable<Events> Events { get; set; } = new List<Events>();
    }
}
