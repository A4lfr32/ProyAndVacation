using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyAndProgram
{
    class Personal:Persona
    {
        //Atributo del personal
        protected string trabajo;
        //Constructor del personal
        public Personal(string nombre, string apellido, string documento, bool sexo, string trabajo): base(nombre, apellido, documento,sexo)
        {

            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Sexo = sexo;
            this.Documento = documento;
            this.trabajo = trabajo;
        }
        //get del personal
        public string getTrabajo()
        {
            return this.trabajo;
        }
        //Destructor de clase
        ~Personal() { }
    }
}
