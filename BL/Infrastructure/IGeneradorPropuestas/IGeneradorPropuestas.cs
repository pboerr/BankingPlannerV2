using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IGeneradorPropuestas
    {
        //Esta interfaz puede aplicar tanto a un GestorServicios como a un Prestador.
        List<IPropuestaServicio> ProponerRequerimiento(IDatosProponerRequerimiento datosPropuesta);

    }
}
