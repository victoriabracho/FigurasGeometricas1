using FigurasGeometricas1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas1
{
    public class Circulo : FigurasGeometricas1
    {
        private double radio;

        public Circulo(double radio) : base("Círculo")
        {
            this.radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
        ~Circulo() { }
    }
}
