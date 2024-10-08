using FigurasGeometricas1;
using System;
using System.Collections.Generic;

namespace FigurasGeometricas1
{
    internal class Menú
    {
        private List<Opciones> opciones;
        private List<FigurasGeometricas1> figuras; // Colección del tipo abstracto


        public Menú()
        {
            figuras = new List<FigurasGeometricas1>();// Inicializar la colección para almacenar figuras geométricas

            opciones = new List<Opciones>()
            {
                new Opciones("Usar Círculo", HacerCirculo),
                new Opciones("Usar Rectángulo", HacerRectangulo),
                new Opciones("Usar Cuadrado", HacerCuadrado),
                new Opciones("Usar Pentágono", HacerPentagono),
                new Opciones("Ver figuras almacenadas", () => MostrarFiguras()),
                new Opciones("Salir", ()=>Environment.Exit(0))
            };

            while (true)
            {
                MostrarMenu();
                SeleccionarOpcion();
            }
        }

        public void MostrarMenu()
        {
            Console.WriteLine("\n¿Con qué figura deseas trabajar?");
            for (int i = 0; i < opciones.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {opciones[i].Message}");
            }
        }

        private void SeleccionarOpcion()
        {
            Console.Write("\nSeleccione una opción: ");
            int numOpcion = int.Parse(Console.ReadLine()) - 1;

            if (numOpcion >= 0 && numOpcion < opciones.Count)
            {
                opciones[numOpcion].Action.Invoke();
            }
            else
            {
                Console.WriteLine("La opción no es válida.");
            }
        }

        // Configurar y trabajar con las figuras
        private void HacerCirculo()
        {
            Console.Write("\nIngresa el radio del círculo: ");
            double radio = double.Parse(Console.ReadLine());
            Circulo circulo = new Circulo(radio);
            figuras.Add(circulo); //agrega el objeto a la colección
            SubMenu(circulo);
        }

        private void HacerRectangulo()
        {
            Console.Write("\nIngresa el largo del rectángulo: ");
            double ladoA = double.Parse(Console.ReadLine());
            Console.Write("Ingresa el ancho del rectángulo: ");
            double ladoB = double.Parse(Console.ReadLine());
            Rectángulo rectangulo = new Rectángulo(ladoA, ladoB);
            figuras.Add(rectangulo); //agrega el objeto a la colección
            SubMenu(rectangulo);
        }

        private void HacerCuadrado()
        {
            Console.Write("\nIngresa el lado del cuadrado: ");
            double lado = double.Parse(Console.ReadLine());
            Cuadrado cuadrado = new Cuadrado(lado);
            figuras.Add(cuadrado); //agrega el objeto a la colección
            SubMenu(cuadrado);
        }

        private void HacerPentagono()
        {
            Console.Write("\nIngresa el lado del pentágono: ");
            double lado = double.Parse(Console.ReadLine());
            Console.Write("Ingresa la apotema del pentágono: ");
            double apotema = double.Parse(Console.ReadLine());
            Pentágono pentagono = new Pentágono(lado, apotema);
            figuras.Add(pentagono); //agrega el objeto a la colección
            SubMenu(pentagono);
        }

        private void SubMenu(FigurasGeometricas1 figura)
        {
            // Submenú con opciones para calcular área o perímetro
            List<Opciones> subOpciones = new List<Opciones>()
            {
                new Opciones("Calcular Área", () => Area(figura)),
                new Opciones("Calcular Perímetro", () => Perimetro(figura)),
                new Opciones("Volver al Menú Principal", () => { /* Sale del submenú */ })
            };

            while (true)
            {
                Console.WriteLine($"\n¿Qué deseas hacer con el {figura.Nombre()}?");
                for (int i = 0; i < subOpciones.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {subOpciones[i].Message}");
                }

                Console.Write("\nSeleccione una opción: ");
                int numSubOpcion = int.Parse(Console.ReadLine()) - 1;

                if (numSubOpcion >= 0 && numSubOpcion < subOpciones.Count)
                {
                    subOpciones[numSubOpcion].Action.Invoke();
                    if (numSubOpcion == subOpciones.Count - 1)
                    {
                        // Sale del submenú si elige "Volver al Menú Principal"
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Opción no válida.");
                }
            }
        }

        private void Area(FigurasGeometricas1 figura)
        {
            Console.WriteLine($"El área es: {figura.CalcularArea()} u^2");
        }

        private void Perimetro(FigurasGeometricas1 figura)
        {
            Console.WriteLine($"El perímetro es: {figura.CalcularPerimetro()} u");
        }
        private void MostrarFiguras()
        {
            if (figuras.Count == 0)
            {
                Console.WriteLine("\nNo hay figuras en la colección.");
                return;
            }

            Console.WriteLine("\nLas figuras almacenadas son las siguientes:");
            foreach (var figura in figuras)
            {
                Console.WriteLine($"Figura: {figura.Nombre()}");
                Console.WriteLine($"Área: {figura.CalcularArea()} u^2");
                Console.WriteLine($"Perímetro: {figura.CalcularPerimetro()} u");
                Console.WriteLine("***********************");
            }
        }
    }
}
