using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApp1
{
    class User
    {
        public int id;
        public string name;
        public string city;
        public string dateofbirth;
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            User[] users = {
                new User { id = 1,name="john",city="london",dateofbirth="2001-05-21" },
                new User { id = 2,name="windy",city="singapore",dateofbirth="2002-06-23" },
                new User { id = 3,name="barbara",city="hongkong",dateofbirth="2003-08-7" },
                new User { id = 4,name="nick",city="hongkong",dateofbirth="2001-04-9" },
                new User { id = 5,name="paul",city="singapore",dateofbirth="2004-03-23" },
                new User { id = 6,name="andika",city="singapore",dateofbirth="2001-123-23" },
                new User { id = 7,name="herman",city="london",dateofbirth="2001-07-21" },
                new User { id = 8,name="sadiq",city="london",dateofbirth="2003-4-21" },
                new User { id = 9,name="casselyn",city="hongkong",dateofbirth="2004-05-21" },
                new User { id = 10,name="miki",city="singapore",dateofbirth="2005-08-21" }
            };

            var result = from us;
            foreach (var i in result)
            {

                Console.WriteLine(i);
            }
        }
    }
}