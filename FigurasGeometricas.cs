using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas1
{
    // Clase abstracta base para las figuras geométricas
    public abstract class FigurasGeometricas1
    {
        protected string nombre;

        public FigurasGeometricas1(string nombre)
        {
            this.nombre = nombre;
        }

        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();

        public string Nombre()
        {
            return nombre;
        }
    }
}