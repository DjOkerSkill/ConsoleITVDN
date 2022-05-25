using System;
using System.IO;

namespace ConsoleITVDN
{
    internal class Program
    {
        static int Addition(int num1, int num2) 
        { 
            return num1 + num2;
        }

        static  int Div (int oper1, int oper2) 
        {
            if (oper1 != 0 && oper2 != 0) return oper1 / oper2;
            else return 0;
        }

        static int Sub(int oper1, int oper2) 
        { 
            return oper1 - oper2; 
        }

        static int Mult(int oper1, int oper2)
        {
            return oper1 * oper2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("My first commit");
            Console.WriteLine("Hello world");
            Console.WriteLine();
        }       

    }
}
