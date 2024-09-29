using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDptoVehicular.Models
{
    public class Persona
    {
        int dni;
        public string Nombre { get; set; }
        public int DNI
        {
            get
            {
                return dni;
            }
            set
            {
                if (value<=1000000)//acá me confundía. Hice la comparación con dni y 
                    //no me saltaba la excepción porque claro, dni nunca se pudo settear.
                {
                    throw new DniNoValidoException();
                }
                else
                {
                    dni = value;
                }
            }
        }

        public Persona(int dni, string nombre)
        {
            DNI = dni;
            Nombre = nombre;
        }
    }
}
