using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IPrestador
    {
        EstadoPrestador EstadoPrestador { get; }
        IPropuestaServicio PropuestaServicio { get; }
        IEventoRequerimiento IniciarRequerimiento(IPropuestaServicio propuestaSeleccionada);
        void FinalizarRequerimiento(IDatosFinalizarRequerimiento datosFinalizarRequerimiento);
        HashSet<ITipoRequerimiento> TiposRequerimientoHabilitados { get; }
        //void AgregarTipoRequerimiento(string tipoRequerimiento);
        //void RemoverTipoRequerimiento(string tipoRequerimiento);
        //List<IPropuestaServicio> ProponerRequerimiento(IDatosProponerRequerimiento datosProponer);
        IGestorServicios GestorServicios { get; }
    }
}
