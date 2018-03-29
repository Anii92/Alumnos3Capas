using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic.Models;

namespace Vueling.Common.Logic
{
    public class FileUtils
    {
        public string ToJson(string data, Alumno alumno)
        {
            throw new NotImplementedException();
        }

        public static string ToString(Alumno alumno)
        {
            return alumno.Id + "," + alumno.Nombre + "," + alumno.Apellidos + "," + alumno.Dni + "," + alumno.Edad + "," + alumno.FechaNacimiento + "," + alumno.FechaHora + "," + alumno.MiGuid;
        }
    }
}
