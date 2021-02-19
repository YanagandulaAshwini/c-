using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            float cel;
            Console.WriteLine("enter the celicius temperature:");
            cel = float.Parse(Console.ReadLine());
            Console.Write(celc_to_fhar(cel));
            Console.ReadKey();

        }
        static float celc_to_fhar(float c)
        {
            Console.WriteLine("the fahrenheit is:");
            return ((c * 9.0f / 5.0f) + 32.0f);
        }
    }
}
