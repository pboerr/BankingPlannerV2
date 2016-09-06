using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class InterrupcionDisponibilidadEfectivo : IInterrupcion
    {
        public DateTime DtInicio { get; }
        public DateTime DtFin { get; }
        public IInterrumpible Interrumpido { get; private set; }
        public IPrestadorSoporte PrestadorSoporte { get; private set; }

        ITipoRequerimiento _TipoRequerimientoSoporte;
        public InterrupcionDisponibilidadEfectivo(DateTime dtInicio, IInterrumpible objetoInterrumpido, ITipoRequerimiento tipoRequerimiento)
        {
            DtInicio = dtInicio;
            Interrumpido = objetoInterrumpido;
            _TipoRequerimientoSoporte = tipoRequerimiento; 

        }

        public void IniciarInterrupcion()
        {
            var abastecimientoSoporte = new AbastecimientoEfectivo(DtInicio, Interrumpido.GestorServicios, (IPrestadorClientes)Interrumpido, 
                                                                      1000, _TipoRequerimientoSoporte, EstadoRequerimiento.Ingresado);
            var eventoLimiteAbandono = abastecimientoSoporte.IngresarRequerimiento()
        }
        public void IniciarSoporte()
        {

        }
        public void FinalizarInterrupcion(DateTime fecha)
        {
            throw new NotImplementedException();
        }

    }
}
