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
        public int DNI
        {
            get
            {
                return dni;
            }
            set
            {
                if (dni>1000000)
                {
                    dni = value;
                }
                else
                {
                    throw new DniNoValidoException();
                }
            }
        }
        public string Nombre { get; set; }
        public string Correo { get; set; }

        public Persona(int dni, string nombre, string correo)
        {
            DNI = dni;
            Nombre = nombre;
            Correo = correo;
        }
    }
}
