using System.Collections.Generic;
using System.Data.Entity;

namespace MCP70480jsMVC.Models
{
    public class BasicContextInitializer : DropCreateDatabaseAlways<BasicContext>
    {
        protected override void Seed(BasicContext context)
        {
            var member = new List<Member>
            {
                new Member()
                {
                    Id = 1,
                    Name = "yamada",
                },
                new Member()
                {
                    Id = 2,
                    Name = "satonaka",
                }
            };
            member.ForEach(m => context.Members.Add(m));
            context.SaveChanges();

        }
    }
}