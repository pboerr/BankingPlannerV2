using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class PropuestaMovimiento
    {
        IGestorServicios NodoInicio { get; set; }
        IGestorServicios NodoFin { get; set; }
        DateTime DtInicio { get; set; }
        DateTime DtFin { get; set; }
        double Costo { get; set; }
    }
}
