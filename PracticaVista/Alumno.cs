using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaVista
{
    class Alumno
    {
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public string Carrera { get; set; } // por medio de autoproperties

        public Alumno() //constructor con el mismo nombre de la clase
        {
            Nombre = "";
            Matricula = "";
            Carrera = "";
        }
        public Alumno(string nombre, string matricula, string carrera)
        { // miembro de la clase - parametro
            Nombre = nombre;
            Matricula = matricula;
            Carrera = carrera;
        }
    }
}
