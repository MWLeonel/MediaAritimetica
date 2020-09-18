using System;

namespace MediaAritimetica
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1;
            double valor2;
            double valor3;
            double result;

            Console.Write("Digite o 1º ºValor: ");
            valor1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o 2º Valor: ");
            valor2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o 3º Valor: ");
            valor3 = double.Parse(Console.ReadLine());
            Console.Write("\n");

            result = (valor1 + valor2 + valor3) / 3;
            Console.WriteLine("Sua Média é = {0}", result);
            Console.Write("\n");

            Console.WriteLine("Pressione ENTER para sair!");
            Console.ReadKey();
        }
    }
}
