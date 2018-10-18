using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaVista
{
    class Materia
    {
        public string Clave { get; set; }
        public string Nombre { get; set; }

        public int CaliPrimerParcial { get; set; }
        public int CaliSegundoParcial { get; set; }
        public int CaliTercerParcial { get; set; }
        public int CaliFinal { get; set; }

        public Materia(string clave, string nombre)
        {
            Clave = clave;
            Nombre = nombre;

            CaliPrimerParcial = 0;
            CaliSegundoParcial = 0;
            CaliTercerParcial = 0;
            CaliFinal = 0;
        }

        public Materia(string clave, string nombre, int caliPrimerParcial,
            int caliSegundoParcial, int caliTercerParcial,int caliFinal)
        {
            Clave = clave;
            Nombre = nombre;

            CaliPrimerParcial = caliPrimerParcial;
            CaliSegundoParcial = caliSegundoParcial;
            CaliTercerParcial = caliTercerParcial;
            CaliFinal = caliFinal;
        }
    }
}
