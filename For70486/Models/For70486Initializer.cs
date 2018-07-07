using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace For70486.Models
{
    public class For70486Initializer : DropCreateDatabaseAlways<For70486Context>
    {
        protected override void Seed(For70486Context context)
        {
            var members = new List<Member>()
            {
                new Member()
                {
                    Name = "Hirobumi.Ito",
                    Birth = DateTime.Parse("1841-10-16"),
                    Email = "hirobumi.ito@example.com",
                    Married = true,
                    Memo = "周防国出身。長州藩の私塾である松下村塾に学び、幕末期の尊王攘夷・倒幕運動に参加。維新後は薩長の藩閥政権内で力を伸ばし、岩倉使節団の副使、参議兼工部卿、初代兵庫県知事（官選）を務め、大日本帝国憲法の起草の中心となる。"
                },
                new Member()
                {
                    Name = "Shinzo Abe",
                    Birth = DateTime.Parse("1954-9-21"),
                    Email = "shinzo.abe@example.com",
                    Married = true,
                    Memo = "Japanese politician serving as the 63rd and current Prime Minister of Japan and Leader of the Liberal Democratic Party (LDP) since 2012, previously being the 57th officeholder from 2006 to 2007. He is the third-longest serving Prime Minister in post-war Japan."
                },
                new Member()
                {
                    Name = "Margaret Hilda Thatcher",
                    Birth = DateTime.Parse("1925-10-13"),
                    Email = "mthatcher@example.com",
                    Married = false,
                    Memo = "Margaret Thatcher's political career has been one of the most remarkable of modern times. Born in October 1925 at Grantham, a small market town in eastern England, she rose to become the first (and for two decades the only) woman to lead a major Western democracy. She won three successive General Elections and served as British Prime Minister for more than eleven years (1979-90), a record unmatched in the twentieth century."
                }
            };

            members.ForEach(m => context.Members.Add(m));
            context.SaveChanges();
        }
    }
}