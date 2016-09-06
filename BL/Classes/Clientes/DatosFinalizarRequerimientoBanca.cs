using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class DatosFinalizarRequerimientoBanca : IDatosFinalizarRequerimiento
    {
        public IEvento EventoOrigen { get; set; }
        public DatosFinalizarRequerimientoBanca(IEvento eventoOrigen)
        {
            EventoOrigen = eventoOrigen;
        }
    }
}
