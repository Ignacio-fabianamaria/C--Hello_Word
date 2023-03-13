using System;
namespace HelloWorld
{
    class Program
    {
        static int num = 5;
        static void Main(string[] args)
        {
            int num2 = 4;
            Console.WriteLine("variável de escopo global num: " + num);
            Console.WriteLine("variável de escopo local num2: "+num2);
            Console.WriteLine("multiplicação usando uma variavel global e local: "+(num*num2));
            Console.WriteLine("divisão usando uma variavel global e local: "+(num/num2));
            Console.WriteLine("adição usando uma variavel global e local: "+(num+num2));
            Console.WriteLine("msubtração usando uma variavel global e local: "+(num-num2));




        }
    }
}

