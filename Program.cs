using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            for(int i = 1; i<1000; i++) {
                if ((i % 3) == 0 || ((i % 5) == 0))
                {
                    result += i;
                }
            }

            Console.WriteLine("The sum of all numbers dividable by 3 or 5 is:"+result+"" );
            Console.ReadLine();
            
        }
    }
}
