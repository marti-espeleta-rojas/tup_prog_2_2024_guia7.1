using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDptoVehicular.Models
{
    internal class DniNoValidoException:ApplicationException
    {
        public DniNoValidoException() : base("DNI debe ser mayor a un millón") { }
        public DniNoValidoException(string msg) : base(msg) { }
        public DniNoValidoException(string msg, Exception e) : base(msg, e) { }
    }
}
