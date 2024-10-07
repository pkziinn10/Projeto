using System;
using System.Globalization;
namespace program
{
    class Program
    {
        static void Main(String[] args)
        {
           bool n1 = true;
            char genero = 'f';
            char letra = '\u0090';
            byte n2 = 255;
            int n3 = 1000;
            int n4 = 2147483647;
            long n5 = 214748364754;
            float n6 = 4.5f;
            double n7 = 5.5;
            string n8 = "Pedro Kauan";
            object n9 = "Pedro kauan 19" ;

            Console.WriteLine(genero);
            Console.WriteLine(letra); 
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6); 
            Console.WriteLine(n7);
            Console.WriteLine(n8);
            Console.WriteLine(n9);
--------------------------------------------------------------------------------
            int n1 = int.MinValue;
            int n2 = int.MaxValue;
            sbyte n3 = sbyte.MinValue;
            sbyte n4 = sbyte.MaxValue;
            float n5 = float.MinValue;
            float n6 = float.MaxValue;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
        }
    }
};
