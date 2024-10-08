using FigurasGeometricas1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas1
{
    public class Rectángulo : FigurasGeometricas1
    {
        private double ladoA;
        private double ladoB;

        public Rectángulo(double ladoA, double ladoB) : base("Rectángulo")
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
        }

        public override double CalcularArea()
        {
            return ladoA * ladoB;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (ladoA + ladoB);
        }
        ~Rectángulo() { }
    }
}
