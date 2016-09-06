using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class DatosProponerRequerimientoBanca : IDatosProponerRequerimiento
    {
        public List<IRequerimiento> FilaEsperaRequerimientos { get; set; }
        public DateTime Fecha { get; set; }
        public DatosProponerRequerimientoBanca(DateTime fecha)
        {
            FilaEsperaRequerimientos = new List<IRequerimiento>();
            Fecha = fecha;
        }
        public DatosProponerRequerimientoBanca(DateTime fecha, List<IRequerimiento> filaEspera)
        {
            FilaEsperaRequerimientos = filaEspera;
            Fecha = fecha;
        }
    }
}
