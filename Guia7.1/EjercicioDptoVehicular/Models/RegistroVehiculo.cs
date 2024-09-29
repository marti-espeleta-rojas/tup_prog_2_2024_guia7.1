using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EjercicioDptoVehicular.Models
{
    public class RegistroVehiculo:IComparable
    {
        string patente;
        public string Patente { get; set; }
        public Persona Propietario { get; set; }

        public RegistroVehiculo(string patente, Persona propietario)
        {
            //acá va el lanzamiento de la excepción 1 si la patente no son tres letras
            //y tres números.
            Patente = patente;
            Propietario = propietario;
            //recordemos que Match representa los resultados de coincidencia de patrones
            /*Regex.Match recibe un string input (en este caso patente.Trim())
             * un patrón (definido en este caso por @"^[A-Z]{3}\s*[0-9]{3}$", y 
             * RegexOptions.IgnoreCase que omite que sean mayúsculas o minúsculas. 
             */
            Match m = Regex.Match(patente.Trim(), @"^[A-Z]{3}\s*[0-9]{3}$", RegexOptions.IgnoreCase);
            if (m.Success == false) //acá se detectaría patente inválida
            {
                throw new FormatoPatenteNoValidaException(); //se lanza la excepción
               
            }
            /*notá cómo desde la llamada al método RegistroVehiculo se llama la excepción.
             *Acá se vé que desde este método, se le pasa la excepción al método que llamó a este
             *método y así hasta llegar a la interfaz principal
            */
        }

        public int CompareTo(object obj)
        {
            RegistroVehiculo r = obj as RegistroVehiculo;
            if (r!= null)
            {
                return this.patente.CompareTo(r.Patente);
            }
            return 1;
        }

        public override string ToString()
        {
            return $"{Patente} - {Propietario.Nombre} - {Propietario.DNI}";
        }
    }
}
