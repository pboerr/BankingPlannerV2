using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface ICliente
    {
        ISimulador Simulador { get; }
        string Nombre { get; }
        ITipoCliente TipoCliente { get; }
        int Sla { get; }
        int Prioridad { get; }
        double Valor { get; }
        int NivelExigencia { get; }
        List<IVisita> Visitas { get; }
        
    }
}
