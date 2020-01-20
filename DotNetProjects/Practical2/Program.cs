using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical2
{
    class Program
    {
        static void Main(string[] args)
        {
            String name, country;
            Console.Write("Please enter the your name : ");
            name = Console.ReadLine();
            Console.Write("Hello !, Where are you frome ? ");
            country = Console.ReadLine();
            Console.WriteLine("Hello "+name+", you are from "+country+".");
            Console.Read();
        }
    }
}
