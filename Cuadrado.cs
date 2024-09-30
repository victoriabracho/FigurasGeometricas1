using FigurasGeometricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas1
{
    internal class Cuadrado : FiguraGeometrica
    {
        private double lado;
        public Cuadrado(double lado) : base("Cuadrado")
        {
            this.lado = lado;
        }

        public override double calcularArea()
        {
            return lado * lado;
        }
        public override double calcularPerimetro()
        {
            return lado * 4;
        }
        public string soyCuadrado()
        {
            return this.Nombre() + ".\nSu perímetro mide: " + calcularPerimetro() +"u"+"\nSu área mide: " + calcularArea()+ "u^2";
        }
        ~Cuadrado()
        {
        }
    }
}
