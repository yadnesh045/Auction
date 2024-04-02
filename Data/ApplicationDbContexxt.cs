


using Auction.Models;
using Microsoft.EntityFrameworkCore;

namespace Auction.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Players> Players { get; set; }

        //Yadnesh

        //Rahul

        //Anurag

        //this is rahul
    }
}
