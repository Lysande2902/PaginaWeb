using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("¿Cuántos triángulos deseas calcular? ");
        int cantidad = int.Parse(Console.ReadLine());

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write("Lado a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Lado b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Lado c: ");
            double c = double.Parse(Console.ReadLine());

            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine($"Área del triángulo {i + 1}: {area:F2}");
        }
    }
}