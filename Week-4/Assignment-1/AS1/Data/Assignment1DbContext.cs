using AS1.Models.UserModel;
using Microsoft.EntityFrameworkCore;

namespace AS1.Data
{
    public class Assignment1DbContext:DbContext
    {
        public Assignment1DbContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
    }
}
