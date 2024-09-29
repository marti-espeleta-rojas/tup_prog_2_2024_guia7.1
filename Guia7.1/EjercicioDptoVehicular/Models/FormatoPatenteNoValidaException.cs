using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDptoVehicular.Models
{
    internal class FormatoPatenteNoValidaException:ApplicationException
    {
        public FormatoPatenteNoValidaException() : base("Patente no válida.") { }
        public FormatoPatenteNoValidaException(string msg) : base(msg) { }
        public FormatoPatenteNoValidaException(string msg, Exception e) : base(msg, e) { }
    }
}
