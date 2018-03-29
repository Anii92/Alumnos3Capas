using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.Common.Logic.Models
{
    public class Alumno: Persona
    {
        public Alumno()
        {

        }
        //[JsonConstructor]
        public Alumno(int id, string nombre, string apellidos, string dni) : base(id, nombre, apellidos, dni)
        {

        }

        public Alumno(int id, string nombre, string apellidos, string dni, string guid) : base(id, nombre, apellidos, dni, guid)
        {

        }
    }
}
