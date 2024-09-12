using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDptoVehicular.Models
{
    public class RegistroVehiculo
    {
        string patente;
        public string Patente
        {
            get
            {
                return patente;
            }
            set
            {
                patente = value;
                if (patente)
                {

                }
            }
        }
        public string Serie { get; private set; }
        public Persona Propietario { get; set; }

        public RegistroVehiculo(string patente, string serie, Persona propietario)
        {
            Patente = patente;
            Serie = serie;
            Propietario = propietario;
        }

        public string VerDetalle()
        {
            return $"Patente: {Patente} - Serie: {Serie} - Propietario:{Propietario.Nombre}";
        }
    }
}
