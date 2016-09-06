using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IArco
    {
        INodo NodoOrigen { get; }
        INodo NodoDestino { get; }
        TimeSpan Duracion { get; }
        double Costo { get; }
    }
}
