using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vueling.Business.Logic;
using Vueling.Common.Logic.Models;
using static Vueling.Common.Logic.Enums.TiposFichero;

namespace Vueling.Presentation.WinSite
{
    public partial class AlumnosShowForm : Form
    {
        private IFicheroBL ficheroBL;
        private List<Alumno> alumnosJson;
        private List<Alumno> alumnosXml;

        public AlumnosShowForm()
        {
            InitializeComponent();
            this.ficheroBL = new FicheroBL();
            this.CargarAlumnosFicheroJson();
            this.CargarAlumnosFicheroXml();
            this.MostrarAlumnosTextoEnPantalla();
        }

        public AlumnosShowForm(Alumno alumno)
        {
            InitializeComponent();
            this.ficheroBL = new FicheroBL();
            this.CargarAlumnosFicheroJson();
            this.CargarAlumnosFicheroXml();
            this.MostrarAlumnoEnPantalla(alumno);
        }

        private void MostrarAlumnoEnPantalla(Alumno alumno)
        {
            List<Alumno> alumnos = new List<Alumno>();
            alumnos.Add(alumno);
            this.EscribirEnPantalla(alumnos);
        }

        private void CargarAlumnosFicheroXml()
        {
            this.alumnosXml = this.ficheroBL.CargarDatosFicheroXml();
        }

        private void CargarAlumnosFicheroJson()
        {
            this.alumnosJson = this.ficheroBL.CargarDatosFicheroJson(); 
        }

        private List<Alumno> LeerDeFicheroDeTexto()
        {
            return this.ficheroBL.Leer(TipoFichero.Texto);
        }

        private void EscribirEnPantalla(List<Alumno> alumnos)
        {
            this.dataGridAlumnos.DataSource = alumnos;
            this.dataGridAlumnos.Update();
        }

        private void MostrarAlumnosTextoEnPantalla()
        {
            List<Alumno> alumnos = this.LeerDeFicheroDeTexto();
            this.EscribirEnPantalla(alumnos);
        }

        private void btnTxtBuscador_Click(object sender, EventArgs e)
        {
            this.MostrarAlumnosTextoEnPantalla();
        }

        private void btnJsonBuscador_Click(object sender, EventArgs e)
        {
            this.EscribirEnPantalla(this.alumnosJson);
        }

        private void btnNombreBuscador_Click(object sender, EventArgs e)
        {
            List<Alumno> alumnosFiltrados = this.ficheroBL.FiltrarFicheroJsonPorNombre(this.txtNombreBuscador.Text);
            this.EscribirEnPantalla(alumnosFiltrados);
        }
    }
}
