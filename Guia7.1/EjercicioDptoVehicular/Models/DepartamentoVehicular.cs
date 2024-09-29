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
        private int serie;
        List<RegistroVehiculo> registros = new List<RegistroVehiculo>();
        RegistroVehiculo vehi = null;

        public RegistroVehiculo RegistrarVehiculo(string patente, Persona propietario)
        {
            vehi = new RegistroVehiculo(patente, propietario);
            registros.Add(vehi);
            return vehi;
        }

        public RegistroVehiculo VerRegistro(int idx)
        {
            vehi = registros[idx];
            return vehi;
        }
    }
}
