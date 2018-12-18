using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyAndProgram
{
    class Prestamos
    {
        //Los atributos de los prestamos
        private string prestador;
        private int codPrestador;
        private string codLibro;
        private string libro;
        private DateTime prestDesde;
        private string prestHasta;
        //Set y get de todos los atributos
        public int CodPrestador
        {
            get { return codPrestador; }
            set { codPrestador = value; }
        }
        public string Prestador
        {
            get { return prestador; }
            set { prestador = value; }
        }
        public string CodLibro
        {
            get { return codLibro; }
            set { codLibro = value; }
        }
        public string Libro
        {
            get { return libro; }
            set { libro = value; }
        }
        public DateTime PrestadoDesde
        {
            get { return prestDesde; }
            set { prestDesde = value; }
        }
        public string PrestadoHasta
        {
            get { return prestHasta; }
            set { prestHasta = value; }
        }
        //constructor para ingresar todos los parametros
        public Prestamos(string pPrestador, int pCodPrestador, string pCodLibro, string pLibro, DateTime pPrestDesde, string pPrestHasta)
        {
            prestador = pPrestador;
            codPrestador = pCodPrestador;
            codLibro = pCodLibro;
            libro = pLibro;
            prestDesde = pPrestDesde;
            prestHasta = pPrestHasta;
        }
        //Sirve para mostrar los datos en el datagridview
        public override string ToString()
        {
            string resp = "";
            resp = prestador + "\t" + Convert.ToString(codPrestador) + "\t" + codLibro + "\t" + libro + "\t" + prestDesde + "\t" + prestHasta;
            return resp;
        }
        //Destructor de clase
        ~Prestamos() { }
    }
}

