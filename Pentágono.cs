using FigurasGeometricas1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas1
{
    public class Pentágono : FigurasGeometricas1
    {
        private double lado;
        private double apotema;

        public Pentágono(double lado, double apotema) : base("Pentágono")
        {
            this.lado = lado;
            this.apotema = apotema;
        }

        public override double CalcularArea()
        {
            return (5 * lado * apotema) / 2;
        }

        public override double CalcularPerimetro()
        {
            return 5 * lado;
        }
        ~Pentágono() { }
    }
}
