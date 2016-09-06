using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class DatosProximoServicioPosible : IDatosProximoServicioPosible
    {
        public DateTime Fecha { get; set; }
        public DatosProximoServicioPosible(DateTime fecha)
        {
            Fecha = fecha;
        }
    }
}
