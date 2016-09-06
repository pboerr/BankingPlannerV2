using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class DatosProcesarLimiteAbandonoBanca : IDatosProcesarLimiteAbandono
    {
        public IEvento EventoOrigen { get; set; }
        public DatosProcesarLimiteAbandonoBanca(IEvento eventoOrigen)
        {
            EventoOrigen = eventoOrigen;
        }

    }
}
