using MembersOfSubscription.Models;
using Microsoft.EntityFrameworkCore;

namespace MembersOfSubscription.Data
{
    public class ApplicationDbContextM : DbContext
    {
        public ApplicationDbContextM(DbContextOptions<ApplicationDbContextM> options) : base(options)
        {

        }
        public DbSet<Male> Males { get; set; }
    }
}
