using System.Collections.Generic;

namespace BL
{
    public interface IDesplazable
    {
        HashSet<IArco> ArcosHabilitados { get; }
        void AgregarArcoHabilitado(IArco nodo);
        void RemoverArcoHabilitado(IArco nodo);
        void IniciarDesplazamiento(IDesplazamiento movimiento);
        void FinalizarDesplazamiento(IDesplazamiento movimiento);
    }
}
