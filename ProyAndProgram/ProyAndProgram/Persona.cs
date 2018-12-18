using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyAndProgram
{
   abstract class Persona
    {
       //Atributos de la persona
       protected string Nombre;  
       protected string Apellido;
       protected string Documento;
       protected bool Sexo; 
       protected short Edad;

       //Constructor de la clase persona
       public Persona(string nombre, string apellido, string documento, bool sexo)
       {
           this.Nombre = nombre;
           this.Apellido = apellido;
           this.Sexo = sexo;
           this.Documento = documento;
       }
       //set y get de la clase persona
        public string getNombre()
        {
            return this.Nombre;
        }
        public string getApellido()
        {
            return this.Apellido;
        }
        public bool getSexo()
        {
            return this.Sexo;
        }
        public string getDocumento()
        {
            return this.Documento;
        }
        public short getEdad()
        {
            return this.Edad;
        }

       //Destructor de clase
        ~Persona() { }

    }
}
