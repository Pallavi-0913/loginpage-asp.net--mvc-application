using Microsoft.EntityFrameworkCore;
using TMS.Models;

namespace TMS.data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<salesLeadentity> SalesLead { get; set; }
    }
}
