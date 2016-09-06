using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class DatosEvaluarProximasInterrupciones : IDatosEvaluarPosiblesInterrupciones
    {
        public DateTime Fecha { get; set; }
        public DatosEvaluarProximasInterrupciones(DateTime fecha)
        {
            Fecha = fecha;
        }
    }
}
