using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introduce un número entero: ");
        int altura = int.Parse(Console.ReadLine());

        for (int i = 1; i <= altura; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}