using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n-----FORMATANDO SAÍDA NO CONSOLE-----\n");

            // tipando as variáveis ao mesmo tempo
            int n1, n2, n3, n4, n5;
            double d1,d2,d3;

            //declarando e atribuindo valor para variável;
            n1 = 10; n2 = 15; n3 = 20; n4 = 25; n5 = 3;
            d1 = 5.50; d3 = 0.1; d2= d1+(d1*d3);
            string produto = "bolo";

            //para imprimir de forma mais simplificada é usado indice para referencia a posição das variaveis
            Console.WriteLine("Mesma linha:\n n1={0}, n2={1}, n3={2}, n4={3}, n5={4},", n1, n2, n3, n4, n5);

            //para imprimir com quebra de linha, troca-se a virgula por \n
            Console.WriteLine("Quebrando linha:\n n1={0}\n n2={1}\n n3={2}\n n4={3}\n n5={4},", n1, n2, n3, n4, n5);

            //inserindo tabulação \t
            Console.WriteLine("Tabulação:\n n1=\t{0}\n n2=\t{1}\n n3=\t{2}\n n4=\t{3}\n n5=\t{4}\n", n1, n2, n3, n4, n5);

            Console.WriteLine("Produto...............:{0,11}",produto);//indice '0' com tabulação de '11'
             Console.WriteLine("Valor de compra......:{0,15:c}",d1);//indice '0' com tabulação de '15' e formato monetário :c
              Console.WriteLine("Lucro...............:{0,16:p}",d3);//indice '0' com tabulação de '16' e formato de porcentagem :p
               Console.WriteLine("Valor de venda.....:{0,17:c}",d2);//indice '0' com tabulação de '17' e formato monetário :c





        }
    }
}

