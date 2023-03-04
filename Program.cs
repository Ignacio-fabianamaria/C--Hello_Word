using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Meu primeiro projeto com C#");

            Console.WriteLine("---Declarando variáveis + valores literais---");

            //char
            char letra = 'a';
            Console.WriteLine("char:" + " " + letra);
            //int
            int numero = 123456;
            Console.WriteLine("int:" + " " + numero);
            //decimal
            decimal numeroDecimal = 4.5m;
            Console.WriteLine("decimal:" + " " + numeroDecimal);
            //bool
            bool verdadeiro = true;
            Console.WriteLine("bool:" + " " + verdadeiro);
            bool falso = false;
            Console.WriteLine("bool:" + " " + falso);
            //string
            string palavra = "amarelo";
            Console.WriteLine("string:" + " " + palavra);
            //double
            double numeroDouble1 = 3.5;
            double numeroDouble2 = 1.5;
            double multplicadoubles = numeroDouble1 * numeroDouble2;
            Console.WriteLine("double" + " " + multplicadoubles);

            //var aceita qualquer dados
            var idade = 35;
            var nome = "Fabiana";
            Console.WriteLine("Nome:" + " " + nome + " - " + "idade:" + " " + idade);

            //Formatação
            double x = 30.255;
            Console.WriteLine(x.ToString("F1"));
            Console.WriteLine(x.ToString("C"));
            Console.WriteLine(x.ToString("P"));


        }
    }
}

