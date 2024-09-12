using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDptoVehicular.Models
{
    public class DepartamentoVehicular
    {
        public int CantidadRegistros { get; private set; }
        ArrayList vehiculos;
        RegistroVehiculo vehi = null;

        public RegistroVehiculo RegistrarVehiculo(string patente, Persona propietario, string serie)
        {
            vehi = new RegistroVehiculo(patente, serie, propietario);
            vehiculos.Add(vehi);
        }

        public RegistroVehiculo VerRegistro(int idx)
        {

        }
    }
}
