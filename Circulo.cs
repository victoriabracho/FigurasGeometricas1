using FigurasGeometricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas1
{
    internal class Circulo : FiguraGeometrica
    {
        private double radio;
        public Circulo(double radio) : base("Circulo")
        {
            this.radio = radio;
        }

        public override double calcularArea()
        {
            return Math.PI * radio * radio;
        }
        public override double calcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
        public string soyCirculo()
        {
            return this.Nombre() + ".\nSu perímetro mide: " + calcularPerimetro() + "u" + "\nSu área mide: " + calcularArea() + "u^2";
        }
        ~Circulo()  
        {
        }

    }
}
