using MembersOfSubscription.Models;
using Microsoft.EntityFrameworkCore;

namespace MembersOfSubscription.Data
{
    public class ApplicationDbContextO : DbContext
    {
        public ApplicationDbContextO(DbContextOptions<ApplicationDbContextO> options) : base(options)
        {

        }
        public DbSet<Other> Others { get; set; }
    }
}
