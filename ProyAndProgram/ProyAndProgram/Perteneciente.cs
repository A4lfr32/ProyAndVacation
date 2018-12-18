using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyAndProgram
{
    class Perteneciente:Persona //colegio
    {
        //Atributos de perteneciente
        protected string Direccion;
        protected string Telefono;
        protected string rh;
        protected string Email;
        protected string ClaveUsuario;
        protected DateTime FechaIngreso;
        //Constructor de perteneciente
        public Perteneciente(string nombre, string apellido, short edad, bool sexo, string documento,
            string direccion, string telefono, string rh, string gmail) : base(nombre,apellido,documento,sexo)
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
            this.FechaIngreso = DateTime.Today;
        }
        //set y get de perteneciente
        public void setClave(string clave)
        {
            this.ClaveUsuario = clave;
        }
        public string getClave()
        {
            return this.ClaveUsuario;
        }
        public string getDireccion()
        {
            return Direccion;
        }
        public string getTelefono()
        {
            return Telefono;
        }
        public string getrh()
        {
            return rh;
        }
        public string getEmail()
        {
            return Email;
        }
        public DateTime getFechaIngreso()
        {
            return this.FechaIngreso;
        }
        //ToString de perteneciente
        public override string ToString()
        {
            return "\n" + this.Nombre + "\t" + this.Apellido + "\t   " + this.Sexo + "\t" + this.Documento + "\t" + this.Direccion + "\t" + this.Telefono;
        }
    }
}

