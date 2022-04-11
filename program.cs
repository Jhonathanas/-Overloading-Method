using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class program
{
    static void Main(string[] args)
    {
        Numbers number = new Numbers();

        Console.WriteLine("Minumun #1: {0}", number.FindMinimumMinumum(3, 1));
        Console.WriteLine("Minumun #2: {0}", number.FindMinimumMinumum(3, 2, 4));
        Console.WriteLine();
        Console.WriteLine("Maximun #1: {0}", number.FindMaximumMinumum(3, 1));
        Console.WriteLine("Maximun #2: {0}", number.FindMaximumMinumum(3, 2, 4));  

        Console.ReadKey();
    }

}