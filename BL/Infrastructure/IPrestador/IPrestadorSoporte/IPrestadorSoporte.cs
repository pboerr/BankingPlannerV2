using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IPrestadorSoporte : IPrestador
    {
        //Prestadores a los que el prestador podria eventualmente prestar un servicio (i.e. soporte)
        HashSet<IPrestadorClientes> SolicitantesHabilitados { get; }
        void AgregarSolicitanteHabilitado(IPrestadorClientes solicitante);
        void RemoverSolicitanteHabilitado(IPrestadorClientes solicitante);
    }
}
