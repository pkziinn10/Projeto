using System;
using System.Globalization;
namespace program
{
    class Program
    {
        static void Main(String[] args)
        {
           
        }
    }
}

/* bool n1 = true;
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
---------------------------------------------------------------------------------
Questão 1
    Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
    mensagem explicativa, conforme exemplos.

            int n1, n2, x;
            Console.WriteLine("Digite um numero:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero por quanto quer somar:");
            n2 = int.Parse(Console.ReadLine()); 
            x = n1 + n2;
            Console.WriteLine("Valor da soma:"+x);
---------------------------------------------------------------------------------
Questão 2
    Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
    casas decimais conforme exemplos.
    Fórmula da área: area = π . raio2
    Considere o valor de π = 3.14159

            double pi, raio, raio2, areaC;
            pi = 3.14159;
            Console.WriteLine("Digite o valor do raio:");
            raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            raio2 = raio * raio;
            areaC = pi * raio2;
            Console.WriteLine("Valor da area da circunferencia e:");
            Console.WriteLine(areaC.ToString("f4",CultureInfo.InvariantCulture));
----------------------------------------------------------------------------------------
Questão 3
    Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
    de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

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
-----------------------------------------------------------------------------------------------------------
Questão 4
    Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
    hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
    decimais.

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
---------------------------------------------------------------------------------------------------------
Questão 5
    Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
    código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.

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
----------------------------------------------------------------------------------------------------------
Questão 6
    Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
    mostre:
    a) a área do triângulo retângulo que tem A por base e C por altura.
    b) a área do círculo de raio C. (pi = 3.14159)
    c) a área do trapézio que tem A e B por bases e C por altura.
    d) a área do quadrado que tem lado B.
    e) a área do retângulo que tem lados A e B.

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
*/ 