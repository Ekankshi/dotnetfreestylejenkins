using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        int Sum()
        {
            int a = 10;
            int b = 20;
            int res = a + b;
            return res;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("The Sum is: "+ p.Sum());
            Console.ReadKey();
        }
    }
}
