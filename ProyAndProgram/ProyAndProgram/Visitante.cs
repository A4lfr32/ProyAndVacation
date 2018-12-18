using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyAndProgram
{
    class Visitante:Persona
    {
       //Atributos de visitantes
       protected string relacion;
       protected string asunto;
        //Constructor de los visitantes
        public Visitante(string nombre, string apellido, string documento, bool sexo,string relacion, string asunto): base(nombre, apellido, documento,sexo)
        {
            this.relacion = relacion;
            this.asunto = asunto;
        }
        //get de los visitantes
        public string getRelacion()
        {
            return this.relacion;
        }
        public string getAsunto()
        {
            return this.asunto;
        }
    }
}
