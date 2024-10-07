Lista de exercícios com C#

Questão 1
    Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
    mensagem explicativa, conforme exemplos.

﻿using System;
using System.Globalization;
namespace program {
    class Program {
        static void Main(String[] args) {
            int n1, n2, x;
            Console.WriteLine("Digite um numero:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero por quanto quer somar:");
            n2 = int.Parse(Console.ReadLine()); 
            x = n1 + n2;
            Console.WriteLine("Valor da soma:"+x);
        }
    }
}

    
