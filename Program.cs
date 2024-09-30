using System;

namespace FigurasGeometricas1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuadrado cuadrado = new Cuadrado(5);
            Console.WriteLine(cuadrado.soyCuadrado());
            Console.WriteLine();
            Circulo circulo = new Circulo(3);
            Console.WriteLine(circulo.soyCirculo());
            Console.WriteLine();
            Rectángulo rectangulo = new Rectángulo(3,2);
            Console.WriteLine(rectangulo.soyRectangulo());
            Console.WriteLine();
            Pentágono pentágono = new Pentágono(2,3);
            Console.WriteLine(pentágono.soyPentagono());
        }
    }
}