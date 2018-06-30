using System.Data.Entity;

namespace MCP70480jsMVC.Models
{
    public class BasicContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
    }
}