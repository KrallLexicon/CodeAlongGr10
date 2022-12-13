using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeAlongGr10.Models
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string? PhoneNumber { get; set; }

        public List<Car> Cars { get; set; } = new List<Car>(); 
    }
}
