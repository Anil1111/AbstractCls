using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Author : Person
    {
        public override void SayName()
        {
            string fullName = FirstName + " " + LastName;
            Console.WriteLine(fullName);
        }
    }
}
