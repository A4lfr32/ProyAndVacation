using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyAndProgram
{
    class Libro
    {
        //Los atributos del libro
        private string codLibro;
        private string titulo;
        private bool Dispinibilidad;
        private string autor;
        private int edicion;
        private string editorial;
        private int ejemplares;
        private string materia;
        private DateTime fechaIngreso;
        //Set y get de todos los atributos
        public string CodLibro
        {
            get { return codLibro; }
            set { codLibro = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public bool Dispinibilidad1
        {
            get
            {
                return Dispinibilidad;
            }

            set
            {
                Dispinibilidad = value;
            }
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public int Edicion
        {
            get { return edicion; }
            set { edicion = value; }
        }
        public string Editorial
        {
            get { return editorial; }
            set { editorial = value; }
        }
        public int Ejemplares
        {
            get { return ejemplares; }
            set { ejemplares = value; }
        }
        public string Materia
        {
            get { return materia; }
            set { materia = value; }
        }
        public DateTime FechaIngreso
        {
            get { return fechaIngreso; }
            set { fechaIngreso = value; }
        }
        //constructor para ingresar todos los parametros
        public Libro(string pCodLibro, bool pDisponibilidad, string pTitulo, string pAutor, int pEdicion, string pEditorial, int pEjemplares, string pMateria, DateTime pFechaIngreso)
        {
            codLibro = pCodLibro;
            Dispinibilidad = pDisponibilidad;
            titulo = pTitulo;
            autor = pAutor;
            edicion = pEdicion;
            editorial = pEditorial;
            ejemplares = pEjemplares;
            materia = pMateria;
            fechaIngreso = pFechaIngreso;
        }
        //Sirve para mostrar los datos en el datagridview
        public override string ToString()
        {
            string resp = "";
            resp = Convert.ToString(codLibro) + "\t" + titulo + "\t"+ Dispinibilidad+ "\t" + autor + "\t" + Convert.ToString(edicion) + "\t" + editorial + "\t" + Convert.ToString(ejemplares) + "\t" + materia + "\t" + fechaIngreso;
            return resp;
        }
        //Destructor de clase
        ~Libro() { }
    }

}

