using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyAndProgram
{
    class Profesor:Perteneciente
    {
        //Atributos de profesores
        protected string Grupo;
        protected string Titulo;
        protected int Escalafon;
        protected bool Jornada;
        protected bool bachillerONo;  
        protected List<Estudiantes> misEstudiantes = new List<Estudiantes>();
        public static int cantidadProfesores;
        //Metodos que obtienen la cantidad de estudiantes que tiene un profesor
        public Estudiantes getMisEstudiantes(int index)
        {
            return this.misEstudiantes[index];
        }
        public int getMisEstudiantesCount() // no pude llamar directamente el tamaño de esta lista desde otra clase
        {
            return this.misEstudiantes.Count;
        }
        public void setMisEstudiantes(Estudiantes agregarMiEstudiante)
        {
            this.misEstudiantes.Add(agregarMiEstudiante);
        }
        public int tamannoMisEstudiantes()
        {
            return this.misEstudiantes.Count;
        }
        //Constructor del profesor
        public Profesor(string nombre, string apellido, short edad, bool sexo, string documento, 
                string direccion, string telefono, string rh, string gmail, string titulo, int escalafon, bool jornada) : base(nombre, apellido, edad, sexo, documento,
            direccion, telefono, rh, gmail)
        {
                this.Titulo = titulo;
                this.Escalafon = escalafon;
                this.Jornada = jornada;
        }
        //Constructor por defecto  
        public Profesor(string nombre, string apellido, short edad, bool sexo, string documento, string direccion, string telefono, string rh, string gmail) : base(nombre, apellido, edad, sexo, documento,
            direccion, telefono, rh, gmail)
        {
            this.Titulo = "";
            this.Escalafon = 0;
            this.Jornada = true;
        }
        public static int contarProfesores()
        {
            //inicializar
            cantidadProfesores += 1;
            return cantidadProfesores;

        }
        //set y get de los profesores
        public string getGrupo()
        { return this.Grupo; }
        public void setGrupo(string grupo)
        { this.Grupo = grupo; }

        public string getTitulo()
        { return this.Titulo; }
        public int getEscalafon()
        { return this.Escalafon; }
        public bool getJornada()
        { return this.Jornada; }


    }
}
