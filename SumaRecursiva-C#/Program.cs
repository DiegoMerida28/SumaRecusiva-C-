using System;

class Program
{
    static int SumaRecursiva(int n)
    {
        // Caso base: cuando n es igual a 0, la suma es 0.
        if (n == 0)
        {
            return 0;
        }
        // Caso recursivo: suma n y el resultado de la suma recursiva de n-1.
        else
        {
            return n + SumaRecursiva(n - 1);
        }
    }

    static void Main()
    {
        Console.Write("Ingresa un número entero positivo: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            if (numero >= 0)
            {
                int resultado = SumaRecursiva(numero);
                Console.WriteLine("La suma de los números enteros del 1 al " + numero + " es: " + resultado);
            }
            else
            {
                Console.WriteLine("El número debe ser positivo.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debes ingresar un número entero.");
        }
    }
}
