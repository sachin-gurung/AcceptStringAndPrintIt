using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcceptStringAndPrintIt
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;

            Console.Write("Accept a string from keyboard :");
            Console.Write("-----------------------------------");
            Console.Write("Input the string : ");
            str = Console.ReadLine();
            Console.Write("The string you entered is : {0}", str);
        }
    }
}
