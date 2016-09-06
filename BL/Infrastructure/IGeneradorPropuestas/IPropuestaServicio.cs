using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IPropuestaServicio //: IInterrumpible
    {
        IRequerimiento Requerimiento { get; set; }
        IPrestador Prestador { get; set; }
        double Costo { get; set; }
        DateTime DtInicio { get; set; }
        DateTime DtFin { get; set; }
        EstadoPropuesta EstadoPropuesta { get; }
        void IniciarPropuesta(); //IEventoFinRequerimiento

    }

    

}
