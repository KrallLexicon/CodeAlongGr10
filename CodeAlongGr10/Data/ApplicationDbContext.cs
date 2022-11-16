using CodeAlongGr10.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeAlongGr10.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            var personId = Guid.NewGuid().ToString();

            modelbuilder.Entity<Person>().HasData(new Person { Id = personId, Name = "Jonathan Krall", Age = 34, PhoneNumber = "0737090202" });
            modelbuilder.Entity<Person>().HasData(new Person { Id = Guid.NewGuid().ToString(), Name = "Sven Svensson", Age = 59, PhoneNumber = "123456" });
            modelbuilder.Entity<Person>().HasData(new Person { Id = Guid.NewGuid().ToString(), Name = "Anna Andersson", Age = 26, PhoneNumber = "845621" });

            modelbuilder.Entity<Car>().HasData(new Car { RegNumber = "ABC-123", Brand = "SAAB", CarModel = "93" });


            modelbuilder.Entity<Person>()
                .HasMany(p => p.Cars)
                .WithMany(c => c.People)
                .UsingEntity(j => j.HasData(new { PeopleId = personId, CarsRegNumber = "ABC-123" }));
        
        }
    }
}
