using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class PropuestaServicio : IPropuestaServicio
    {
        public double Costo { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFin { get; set; }
        public IRequerimiento Requerimiento { get; set; }
        public IPrestador Prestador { get; set; }
        public EstadoPropuesta EstadoPropuesta { get; private set; }

        //TODO falta agregar constructor completo
        public PropuestaServicio()
        {

        }
        public PropuestaServicio(IRequerimiento requerimiento, IPrestador prestador, EstadoPropuesta estadoPropuesta, 
                                        DateTime dtInicio, DateTime dtFin, double costo)
        {
            Requerimiento = requerimiento;
            Prestador = prestador;
            EstadoPropuesta = estadoPropuesta;
            DtInicio = dtInicio;
            DtFin = dtFin; 
            Costo = costo;
        }

        public IEventoRequerimiento IniciarPropuesta()
        {
            var eventoFin = Requerimiento.Iniciar(this);
            return eventoFin;
        }
    }



}
