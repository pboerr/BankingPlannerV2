using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public abstract class Requerimiento : IRequerimiento
    {        
        public DateTime DtIngreso { get; protected set; }
        public DateTime? DtInicio { get; protected set; }
        public DateTime? DtFin { get; protected set; }
        public EstadoRequerimiento EstadoRequerimiento { get; protected set; }
        public ISimulador Simulador { get; private set; }
        public IGestorServicios GestorServicios { get; protected set; }
        public int MinutosDuracion { get; protected set; }
        public ITipoRequerimiento TipoRequerimiento { get; }

        public abstract void Ingresar(DateTime dtIngreso);
        public abstract void Iniciar(IPropuestaServicio propuestaServicio);     
        public abstract void Finalizar(DateTime dtFin);
    }
}
