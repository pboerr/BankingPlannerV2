using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IPrestadorClientes : IPrestador
    {
        HashSet<ITipoCliente> TiposClienteHabilitados { get; }
        void AgregarTipoCliente(ITipoCliente tipoCliente);
        void RemoverTipoCliente(ITipoCliente tipoCliente);       

    }

    
}
