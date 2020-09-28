using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;

            Console.WriteLine("Bem-vindo ao Heron.");
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Calcule a área de um triângulo qualquer, dadas as medidas dos 3 lados:");

            Console.Write("Lado A: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lado B: ");
            b = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Lado C: ");
            c = Convert.ToDouble(Console.ReadLine());

            double area1 = a + b + c;
            double area2 = area1 * 2;
            
            double resultado1 = area2 / 3;
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"A área é: {resultado1}");
            Console.ResetColor();

            double resultado2 = area1 / 2;
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"O semiperímetro é: {resultado2}");
            Console.ResetColor();                        
        }
    }
}
