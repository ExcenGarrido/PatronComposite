using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronComposite
{
    internal class GrupoEstudiantes : IParticipante
    {
        private List<IParticipante> participantes;
        private string nombreGrupo;

        public GrupoEstudiantes(string n)
        {
            participantes = new List<IParticipante>();
            nombreGrupo = n;
        }

        public void agregarParticipante(IParticipante p)
        {
            participantes.Add(p);
        }

        public string getNombre()
        {
            string aux = nombreGrupo + "(";
            foreach (IParticipante p in participantes)
            {
                if (aux.EndsWith("(")) aux += p.getNombre();
                else aux += " + " + p.getNombre();
            }
            return aux + ")";
        }

        public double getPromedio()
        {
            double suma = 0;
            int cont = 0;

            foreach (IParticipante p in participantes)
            {
                suma += p.getPromedio();
                cont++;
            }

            return suma / cont;
        }

        public override string ToString()
        {
            return getNombre();
        }
    }
}