using System;
using System.Globalization;
namespace program {
    class Program {
        static void Main(String[] args) {
             int codigo, qnt,codigo2 , qnt2;
            decimal preco, preco2, valor1, valor2, soma;

            Console.WriteLine("Informe o código do produto:");
            codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade do produto:");
            qnt = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço unitário");
            preco = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o código do produto 2:");
            codigo2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade do produto 2:");
            qnt2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço unitário do produto 2:");
            preco2 = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            valor1 = qnt * preco;
            valor2 = qnt2 * preco2;
            
            Console.WriteLine("Valor peça 1: " + valor1.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Valor peça 2: " + valor2.ToString("F2", CultureInfo.InvariantCulture));

            soma = valor1 + valor2;
            Console.WriteLine("Valor da soma dos 2 produtos: " + "R$" +soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
