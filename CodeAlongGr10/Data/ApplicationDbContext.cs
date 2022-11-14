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
    }
}
