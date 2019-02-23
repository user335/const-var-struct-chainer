using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public Program(string s) : this(s, 1)
        {
            Console.WriteLine("This constructor was used in a chain.");
        }
        public Program(string s, int numberOfTimes)
        {
            const string constString = "THE BEST STRING OF ALL TIME";
            var newString = s;
            Console.WriteLine("Are you ready for this?");
            for (int i = 0; i < numberOfTimes; i++)
            {
                Console.WriteLine(constString + newString);
            }
        }
    }
    class MainClass
    {
        static void Main(string[] args)
        {
            var pp = new Program("...IS ABOUT TO GET EVEN BETTER");
            Console.ReadKey();
        }
    }
}
