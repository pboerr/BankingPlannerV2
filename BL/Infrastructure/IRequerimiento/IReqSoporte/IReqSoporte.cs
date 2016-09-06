using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IReqSoporte : IRequerimiento
    {
        IPrestadorClientes Solicitante { get; }
        IPrestadorSoporte Prestador { get; }
    }
}
