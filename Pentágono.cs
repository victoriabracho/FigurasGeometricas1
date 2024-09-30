using FigurasGeometricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas1
{
    internal class Pentágono : FiguraGeometrica
    {
        private double lado;
        private double apotema;
        public Pentágono(double lado, double apotema) : base("Pentágono")
        {
            this.lado = lado;
            this.apotema = apotema;
        }

        public override double calcularArea()
        {
            return ((lado*5)*apotema)/2;
        }
        public override double calcularPerimetro()
        {
            return lado*5;
        }
        public string soyPentagono()
        {
            return this.Nombre() + ".\nSu perímetro mide: " + calcularPerimetro() + "u" + "\nSu área mide: " + calcularArea() + "u^2";
        }
        ~Pentágono()
        {
        }
    }
}
