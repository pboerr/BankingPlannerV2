using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IRequerimiento
    {
        ISimulador Simulador { get; }
        IGestorServicios GestorServicios { get; }
        DateTime DtIngreso { get; }
        DateTime? DtInicio { get; }
        DateTime? DtFin { get; }
        EstadoRequerimiento EstadoRequerimiento { get; }
        ITipoRequerimiento TipoRequerimiento { get; }
        void Ingresar(DateTime dtIngreso); //Std: ingresa eventoIngreso y devolvemos eventoLimiteAbandono
        void Iniciar(IPropuestaServicio propuestaServicio); //Std: ingresa propuesta y devolvemos eventoFin
        void Finalizar(DateTime dtFin); //Std: ingresa eventoFin y devolvemos List<IEvento>
    }
}
