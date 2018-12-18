using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyAndProgram
{
    class Estudiantes:Perteneciente
    {
        //protected string Grupo;  //* el valor de este atributo es igual al del profesro al que está ligado el estudiante
        protected static int cantidadEstudiantes;
        protected Profesor miProfesorEs;
        protected int cursoGrado;
        protected bool bachillerONo;  // posible en Perteneciente, de la que hereda
       
        //Constructor que le asigna los valores al estudiante
        public Estudiantes(string nombre, string apellido, short edad, bool sexo, string documento,
            string direccion, string telefono, string rh, string gmail, int cursoGrado) : base(nombre, apellido, edad, sexo, documento,
            direccion, telefono, rh, gmail)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Sexo = sexo;
            this.Documento = documento;
            this.Direccion = direccion;
            this.Telefono = telefono;
            //  this.rh = Convert.ToChar("n");
            this.rh = rh;
            this.Email = gmail;
            this.cursoGrado = cursoGrado;
            if (this.cursoGrado > 5)
                this.bachillerONo = true;
            else
                this.bachillerONo = false;


            contarEstudiantes();

        }
        //set y get del profesor y el grado al que pertenece el estudiante
        public void setMiProfesorEs(Profesor miProfesor)
        {
            this.miProfesorEs = miProfesor;
        }
        public Profesor getMiProfesorEs()
        {
            return miProfesorEs;
        }
        public void setCursoGrado(int cursoGrado)
        {
            this.cursoGrado = cursoGrado;
        }
        public int getCursoGrado()
        {
            return cursoGrado;
        }
        protected static int contarEstudiantes() //la lista ya lo hace
        {
            //inicializar
            cantidadEstudiantes += 1;
            return 0;

        }
        //Retorna la cantidad de estudiantes
        public int getCantidadEstudiantes()
        {

            return cantidadEstudiantes;

        }
        //Destructor de clase
        ~Estudiantes() { }
        
        /*public override string ToString()
        {
            return this.Nombre + "\t" + this.Apellido + "\t" + this.Sexo + "\t" + this.Documento + "\t" + this.Direccion + "\t" + this.Telefono +"\n";
        }*/
    }
}
