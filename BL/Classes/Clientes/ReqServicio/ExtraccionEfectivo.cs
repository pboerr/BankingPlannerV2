using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ExtraccionEfectivo : RequerimientoBanca
    {
        int _CantidadEfectivoRequerida { get; set; }
        public ExtraccionEfectivo(int cantidadEfectivoRequerida, IGestorServicios gestorServicios, ITipoRequerimiento tipoRequerimiento,
                                    DateTime dtIngreso, EstadoRequerimiento estadoRequerimiento, ITipoCliente tipoCliente) 
            : base(gestorServicios, tipoCliente, tipoRequerimiento, dtIngreso, estadoRequerimiento)
        {
            _CantidadEfectivoRequerida = cantidadEfectivoRequerida;
        }


        public override List<IEvento> FinalizarRequerimiento(IDatosFinalizarRequerimiento datosFinalizarRequerimiento)
        {
            //Modifico estado de este objeto
            var eventoOrigen = datosFinalizarRequerimiento.EventoOrigen;
            DtFin = eventoOrigen.Fecha;
            EstadoRequerimiento = EstadoRequerimiento.Finalizado;
            //Informo acciones al prestador y al gestor de servicios           
            var requerimiento = (IReqServicio)eventoOrigen.Requerimiento; 
            var prestadorEfectivo = (IPrestadorExtraccionEfectivo)requerimiento.Prestador;
            
            var eventosPorEntregaEfectivo = prestadorEfectivo.EntregarEfectivo(_CantidadEfectivoRequerida, eventoOrigen.Fecha);

            var prestador = requerimiento.Prestador;
            prestador.FinalizarRequerimiento(datosFinalizarRequerimiento);
            //Si hubiera mas acciones, deberiamos consolidar todos los eventos y devolverselos al prestador para que pueda reportarlos.
            return eventosPorEntregaEfectivo;
        }

    }
}
