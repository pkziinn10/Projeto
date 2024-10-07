using System;
using System.Globalization;
namespace program {
    class Program {
        static void Main(String[] args) {
            int numFuncionario;
            double salario, hrsTrabalhadas, quantiaHR;

            Console.WriteLine("Digite o número do funcionário:");
            numFuncionario = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite suas horas trabalhadas:");
            hrsTrabalhadas = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite quanto que você:");
            quantiaHR = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = quantiaHR * hrsTrabalhadas;
            Console.WriteLine("Numero do funcionário: " + numFuncionario);
            Console.WriteLine(("O sálario do funcionário e: ")+"U$"+salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
