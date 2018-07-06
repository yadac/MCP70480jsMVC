using System.Data.Entity;

namespace For70486.Models
{
    public class For70486Context : DbContext
    {
        public DbSet<Member> Members { get; set; }
    }
}