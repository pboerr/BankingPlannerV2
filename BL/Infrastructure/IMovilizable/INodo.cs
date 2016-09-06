using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface INodo
    {
        INodo NodoPadre { get; set; }
        IEnumerable<INodo> NodosHijos { get; }
        void AgregarNodoHijo(INodo nodo);
        void RemoverNodoHijo(INodo nodo);
        IEnumerable<INodo> NodoYDescendientes(INodo nodoInicio);
    }

    




}
