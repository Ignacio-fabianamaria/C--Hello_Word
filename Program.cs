using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OPERADORES");

            Console.WriteLine("Operações aritméticas:");
            int x = 10;
            int y = 3;
            Console.WriteLine("a variavel x é:" + x + " e a variavel y é:" + y);
            Console.WriteLine("Adição: " + (x + y));  // Adição: 13
            Console.WriteLine("Subtração: " + (x - y));  // Subtração: 7
            Console.WriteLine("Multiplicação: " + (x * y));  // Multiplicação: 30
            Console.WriteLine("Divisão: " + (x / y));  // Divisão: 3
            Console.WriteLine("Módulo: " + (x % y));  // Módulo: 1

            Console.WriteLine("_________________________________________");
            Console.WriteLine("operadores relacionais:");
            bool igual = x == y;
            bool diferente = x != y;
            bool maior = x > y;
            bool menor = x < y;
            bool maiorIgual = x >= y;
            bool menorIgual = x <= y;
            Console.WriteLine("a variavel x é:" + x + " e a variavel y é:" + y);
            Console.WriteLine("x == y: " + igual);  // x == y: False
            Console.WriteLine("x != y: " + diferente);  // x != y: True
            Console.WriteLine("x > y: " + maior);  // x > y: True
            Console.WriteLine("x < y: " + menor);  // x < y: False
            Console.WriteLine("x >= y: " + maiorIgual);  // x >= y: True
            Console.WriteLine("x <= y: " + menorIgual);  // x <= y: False

            Console.WriteLine("_________________________________________");

            int a = 10;
            a += 5;   // a = 15


            Console.WriteLine("Operações de atribuição:");
            Console.WriteLine("a variavel 'a' tem o valor de 10: " ); 
            Console.WriteLine("a += 5: " + a);  // a += 5: 15



        }
    }
}

