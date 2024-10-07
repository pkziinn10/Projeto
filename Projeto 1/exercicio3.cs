using System;
using System.Globalization;
namespace program {
    class Program {
        static void Main(String[] args) {
            int a, b, c, d, diference;
            Console.WriteLine("Digite o valor de A:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite valor de B:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite valor de C:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite valor de D:");
            d = int.Parse(Console.ReadLine());
            diference = (a*b) - (c*d);
            Console.WriteLine("O valor da diferença de cada produto e:" + diference);
        }
    }
}
