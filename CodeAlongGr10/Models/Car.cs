using System.ComponentModel.DataAnnotations;

namespace CodeAlongGr10.Models
{
    public class Car
    {
        [Key]
        public string RegNumber { get; set; }

        public string Brand { get; set; }

        public string CarModel { get; set; }

        public List<Person> People { get; set; } = new List<Person>(); 
    }
}
