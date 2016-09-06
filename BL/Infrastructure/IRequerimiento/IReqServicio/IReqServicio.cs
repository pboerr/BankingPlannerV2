using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IReqServicio : IRequerimiento
    {
        ICliente ICliente { get; }
        DateTime? DtAbandono { get; }
        IPrestadorClientes Prestador { get; }
        double ValorMinutosCliente { get; } //cantidad de minutos que el cliente esta dispuesto a esperar
        void EvaluarAbandono(DateTime dtEvaluarAbandono);
    }

    
}
