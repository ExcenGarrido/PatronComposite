using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronComposite
{
    internal class Estudiante : IParticipante
    {
        private string nombre;
        private double promedio;

        public Estudiante(string n, double p)
        {
            nombre = n;
            promedio = p;
        }

        public string getNombre()
        {
            return nombre;
        }

        public double getPromedio()
        {
            return promedio;
        }

        public override string ToString()
        {
            return getNombre() + ", prom: " + promedio;
        }
    }
}