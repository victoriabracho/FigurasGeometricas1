using FigurasGeometricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas1
{
    internal class Rectángulo : FiguraGeometrica
    {
        private double ladoA;
        private double ladoB;
        public Rectángulo(double ladoA, double ladoB) : base("Rectángulo")
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
        }

        public override double calcularArea()
        {
            return ladoA * ladoB;
        }
        public override double calcularPerimetro()
        {
            return (ladoA*2)+(ladoB*2);
        }
        public string soyRectangulo()
        {
            return this.Nombre() + ".\nSu perímetro mide: " + calcularPerimetro() + "u" + "\nSu área mide: " + calcularArea() + "u^2";
        }
        ~Rectángulo()
        {
        }
    }
}
