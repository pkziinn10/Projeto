Questão 2
    Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
    casas decimais conforme exemplos.
    Fórmula da área: area = π . raio2
    Considere o valor de π = 3.14159
﻿using System;
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
