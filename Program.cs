using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging101
{
    class Program
    {
        static void Main(string[] args)
        {
            DoSomeStuff();
        }

        static void DoSomeStuff()
        {
            var value = 42;
            Console.WriteLine($"This will not end well: {value / 0}");
        }
    }
}
