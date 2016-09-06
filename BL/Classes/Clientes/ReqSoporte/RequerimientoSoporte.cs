using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public abstract class RequerimientoSoporte : IReqSoporte
    {
        public IPrestadorClientes Solicitante { get; protected set; }
        public RequerimientoSoporte(DateTime dtIngreso, IGestorServicios gestorServicios, IPrestadorClientes solicitante, 
                                        ITipoRequerimiento tipoRequerimiento, EstadoRequerimiento estadoRequerimiento)
        {
            GestorServicios = gestorServicios;
            Solicitante = solicitante;
            DtIngreso = dtIngreso;
            TipoRequerimiento = tipoRequerimiento;
            EstadoRequerimiento = estadoRequerimiento;
        }
        public IGestorServicios GestorServicios { get; protected set; }
        public ITipoRequerimiento TipoRequerimiento { get; protected set; }
        public IPrestadorSoporte Prestador { get; protected set; }
        public DateTime DtIngreso { get; protected set; }
        public DateTime? DtInicio { get; protected set; }
        public DateTime? DtFin { get; protected set; }
        public EstadoRequerimiento EstadoRequerimiento { get; protected set; }
        public virtual IEventoLimiteAbandono IngresarRequerimiento(IDatosIngresarRequerimiento datosIngresarRequerimiento)
        {
            //Modificamos el estado del requerimiento
            EstadoRequerimiento = EstadoRequerimiento.Ingresado;
            //Informamos el ingreso al IGestorServicios
            GestorServicios.IngresarRequerimiento(datosIngresarRequerimiento);
            //No generamos el evento limiteAbandono porque no aplica.
            return null;
        }
        public virtual IEventoRequerimiento IniciarRequerimiento(IPropuestaServicio propuestaServicio)
        {
            //Extraemos datos
            var fecha = propuestaServicio.DtFin;
            var prestador = propuestaServicio.Prestador;
            //Modificamos estado
            DtInicio = fecha;
            Prestador = (IPrestadorSoporte)prestador;
            EstadoRequerimiento = EstadoRequerimiento.Iniciado;
            //Generamos evento de fin y lo retornamos.
            var eventoFin = new EventoFinRequerimiento(fecha, propuestaServicio.Requerimiento);
            return eventoFin;
        }   
        public abstract List<IEvento> FinalizarRequerimiento(IDatosFinalizarRequerimiento datosFinalizarRequerimiento);
    }



}
