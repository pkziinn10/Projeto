using System;
using System.Globalization;
namespace program {
    class Program {
        static void Main(String[] args) {
            float A, B, C;
            double triangulo, circulo,trapezio,quadrado,retangulo;

            Console.WriteLine("Digite o valor de A:");
            A = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor de B:");
            B = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor de C:");
            C = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            triangulo = (A * C) / 2;
            circulo = 3.14159 * (C * C);
            trapezio =  (A + B) * C / 2;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine(("Triângulo: ")+ (triangulo.ToString("F3",CultureInfo.InvariantCulture)));
            Console.WriteLine(("Circulo: ") + (circulo.ToString("F3", CultureInfo.InvariantCulture)));
            Console.WriteLine(("Trapézio: ") + (trapezio.ToString("F3", CultureInfo.InvariantCulture)));
            Console.WriteLine(("Quadrado: ") + (quadrado.ToString("F3", CultureInfo.InvariantCulture)));
            Console.WriteLine(("Retângulo: ") + (retangulo.ToString("F3", CultureInfo.InvariantCulture)));
        }
    }
}
