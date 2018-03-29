using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.Common.Logic.Models
{
    public class Persona: VuelingObject
    {
        #region Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public DateTime FechaHora { get; set; } 
        #endregion

        public Persona()
        {
            this.MiGuid = Guid.NewGuid().ToString();
        }

        public Persona(int id, string nombre, string apellidos, string dni)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Dni = dni;
            this.MiGuid = Guid.NewGuid().ToString();
        }

        public Persona(int id, string nombre, string apellidos, string dni, string guid)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Dni = dni;
            this.MiGuid = guid;
        }
    }
}
