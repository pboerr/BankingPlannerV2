using System;

namespace BL
{
    public interface IDesplazamiento
    {
        IArco Arco { get; }
        IDesplazable Desplazado { get; }
        DateTime DtInicio { get; }
        DateTime DtFin { get; }
        void Inicio(DateTime dtInicio);
        void Fin(DateTime dtFin);
    }
}
