using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IDatosProponerRequerimiento
    {
        List<IRequerimiento> FilaEsperaRequerimientos { get; set; }
        DateTime Fecha { get; set; }

    }
}
