using ContactsManager.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactsManager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        // Add Models Here
        public DbSet<Contact> Contact { get; set; }

    }
}
