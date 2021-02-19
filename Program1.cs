using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            Console.WriteLine("enter the length of a rectngle");
            length = Int32.Parse(Console.ReadLine());
            int breadth;
            Console.WriteLine("enter the breadth of rectangle");
            breadth = Int32.Parse(Console.ReadLine());
            int perimeter;
            perimeter = 2 * (length + breadth);
            Console.WriteLine("the perimeter is:" +perimeter);
            Console.WriteLine(perimeter);
            Console.ReadKey();

        }

    }



}