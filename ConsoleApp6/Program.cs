using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Author();
            obj.FirstName = "Dennis";
            obj.LastName = "Ritchie";

            obj.SayName();
            Console.ReadLine();
        }
    }
}
