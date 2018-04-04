using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic;
using Vueling.Common.Logic.Models;
using Vueling.DataAccess.Dao.Factories;
using Vueling.DataAccess.Dao.Singleton;
using static Vueling.Common.Logic.Enums.TiposFichero;

namespace Vueling.DataAccess.Dao
{
    public class FicheroDao: IFicheroDao
    {
        private SingletonJson singletonJson;

        public FicheroDao()
        {
            this.singletonJson = SingletonJson.Instance;
        }

        public List<Alumno> Leer(TipoFichero tipoFichero)
        {
            IFichero fichero = (IFichero)FicheroFactory.CrearFichero(tipoFichero, "ListadoAlumno");
            return fichero.Leer();
        }

        public List<Alumno> CargarDatosFicheroJson()
        {
            return this.singletonJson.Leer();
        }

        public List<Alumno> FiltrarFicheroJsonPorNombre(string valor)
        {
            return this.singletonJson.Filtrar(valor);
        }

        public List<Alumno> CargarDatosFicheroXml()
        {
            return new List<Alumno>();
        }
    }
}
