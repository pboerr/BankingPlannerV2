using System;

namespace BL
{
    public interface IInterrupcion
    {
        DateTime DtInicio { get; }
        DateTime DtFin { get; }
        IInterrumpible Interrumpido { get; }
        ITipoInterrupcion TipoInterrupcion { get; }
        ITipoRequerimiento TipoRequerimientoSoporte { get; }
        void IniciarInterrupcion();
        void IniciarSoporte();
        void FinalizarInterrupcion(DateTime fecha);
    }


}
