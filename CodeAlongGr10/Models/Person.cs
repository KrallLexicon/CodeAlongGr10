using System.ComponentModel.DataAnnotations;

namespace CodeAlongGr10.Models
{
    public class Person
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string? PhoneNumber { get; set; }

        public List<Car> Cars { get; set; } = new List<Car>(); 
    }
}
