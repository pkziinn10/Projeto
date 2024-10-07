using System;
using System.Globalization;
namespace program {
    class Program {
        static void Main(String[] args) {
            double pi, raio, raio2, areaC;
            pi = 3.14159;
            Console.WriteLine("Digite o valor do raio:");
            raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            raio2 = raio * raio;
            areaC = pi * raio2;
            Console.WriteLine("Valor da area da circunferencia e:");
            Console.WriteLine(areaC.ToString("f4",CultureInfo.InvariantCulture));
        }
    }
}
