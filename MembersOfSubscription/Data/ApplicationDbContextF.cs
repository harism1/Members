using MembersOfSubscription.Models;
using Microsoft.EntityFrameworkCore;

namespace MembersOfSubscription.Data
{
    public class ApplicationDbContextF : DbContext
    {
        public ApplicationDbContextF(DbContextOptions<ApplicationDbContextF> options) : base(options)
        {

        }
        public DbSet<Female> Females { get; set; }
    }
}
