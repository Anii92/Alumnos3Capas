using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.Common.Logic.Models
{
    public class FicheroJson: IFichero
    {
        public string Nombre { get; set; }
        public string Ruta { get; set; }

        public FicheroJson(string nombre, string ruta)
        {
            this.Nombre = nombre;
            this.Ruta = ruta;
        }

        public void Guardar(Alumno alumno)
        {
            throw new NotImplementedException();
        }
    }
}
