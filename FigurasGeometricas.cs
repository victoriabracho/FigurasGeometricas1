using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    internal class FiguraGeometrica
    {
        protected string nombre;

        public FiguraGeometrica(string nombre)
        {
            this.nombre = nombre;
        }

        public virtual double calcularArea()
        {
            return 0.0;
        }

        public virtual double calcularPerimetro()
        {
            return 0.0;
        }

        public string Nombre()
        {
            return $"La figura es un " + nombre;
        }

    }
}