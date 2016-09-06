using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IPrestadorExtraccionEfectivo
    {
        List<IEvento> EntregarEfectivo(int cantidadEfectivo, DateTime fecha);

    }
}
