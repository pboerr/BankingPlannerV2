using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class DatosIngresarRequerimientoBanca : IDatosIngresarRequerimiento
    {
        public IEventoIngresoRequerimiento EventoOrigen { get; set; }

        public DatosIngresarRequerimientoBanca(IEventoIngresoRequerimiento eventoOrigen)
        {
            EventoOrigen = eventoOrigen;
        }

    }
}
