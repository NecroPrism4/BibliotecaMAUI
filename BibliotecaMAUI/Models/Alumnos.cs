using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
     internal class Alumnos
    {
        public string Identificador { get; set; }
        public string Nombre { get; set; }
        public string Carrera { get; set; }
        public string Semestre { get; set; }

        public Alumnos(string identificador, string nombre, string carrera, string semestre)
        {
            Identificador = identificador;
            Nombre = nombre;
            Carrera = carrera;
            Semestre = semestre;
        }
    }
    internal class Docentes {
        public string No_Empleado { get; set; }
        public string Nombre { get; set; }

        public Docentes(string no_Empleado, string nombre)
        {
            No_Empleado = no_Empleado;
            Nombre = nombre;

        }
    }
}
