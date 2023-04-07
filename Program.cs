namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\x1b[4m👩‍🏫Aqui estão alguns exemplos de declarações das principais tipagens de variáveis em C#:\x1b[0m");

            Console.WriteLine("Tipos de valor:🌱");

            char letra = 'a';
            Console.WriteLine("char:" + " " + letra);
            int numero = 123456;
            Console.WriteLine("int:" + " " + numero);
            decimal numeroDecimal = 4.5m;
            Console.WriteLine("decimal:" + " " + numeroDecimal);
            bool verdadeiro = true;
            Console.WriteLine("bool:" + " " + verdadeiro);
            bool falso = false;
            Console.WriteLine("bool:" + " " + falso);
            string palavra = "amarelo";
            Console.WriteLine("string:" + " " + palavra);
            Console.WriteLine("__________________________________________________");
            Console.WriteLine("Arrray");
            int[] numeros = new int[] { 1, 2, 3 };
            Console.WriteLine($"o array de números é :{string.Join(", ", numeros)}");
            string[] frutas = new string[] { "uva", "banana", "laranja" };
            Console.WriteLine($"As frutas são: {string.Join(", ", frutas)}");
            

        }
    }
}

