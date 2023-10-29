using System;

class Program
{
    static int SumaRecursiva(int n)
    {
        if (n <= 9)
            return n;
        else
            return SumaRecursiva(n / 10) + n % 10;
    }

    static void Main(string[] args)
    {
        Console.Write("Ingresa un número entero: ");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            int resultado = SumaRecursiva(n);
            Console.WriteLine($"La suma de los dígitos de {n} es: {resultado}");
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debes ingresar un número entero.");
        }
    }
}