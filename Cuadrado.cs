using FigurasGeometricas1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas1
{
        public class Cuadrado : FigurasGeometricas1
    {
        private double lado;

        public Cuadrado(double lado) : base("Cuadrado")
        {
            this.lado = lado;
        }

        public override double CalcularArea()
        {
            return lado * lado;
        }

        public override double CalcularPerimetro()
        {
            return lado * 4;
        }
        ~Cuadrado() { }
    }
}
