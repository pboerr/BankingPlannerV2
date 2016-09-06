using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public abstract class RequerimientoBanca : IReqServicio
    {
        public RequerimientoBanca()
        {

        }
        public RequerimientoBanca(IGestorServicios gestorServicios, ITipoCliente tipoCliente, ITipoRequerimiento tipoRequerimiento, 
                                        DateTime dtIngreso, EstadoRequerimiento estadoRequerimiento, double valorCliente)
        {
            GestorServicios = gestorServicios;
            TipoCliente = tipoCliente;
            TipoRequerimiento = tipoRequerimiento;
            DtIngreso = dtIngreso;
            EstadoRequerimiento = estadoRequerimiento;
            ValorMinutosCliente = valorCliente;
        }
        public double ValorMinutosCliente { get; protected set; }
        public IGestorServicios GestorServicios { get; protected set; }
        public ITipoCliente TipoCliente { get; protected set; }
        public ITipoRequerimiento TipoRequerimiento { get; protected set; }
        public IPrestadorClientes Prestador { get; protected set; }
        public DateTime DtIngreso { get; protected set; }
        public DateTime? DtInicio { get; protected set; }
        public DateTime? DtFin { get; protected set; }
        public DateTime? DtAbandono { get; protected set; }
        public EstadoRequerimiento EstadoRequerimiento { get; protected set; }

        public ICliente ICliente
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ISimulador Simulador
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual IEventoLimiteAbandono IngresarRequerimiento(IDatosIngresarRequerimiento datosIngresarRequerimiento)
        {
            //Modificamos el estado del requerimiento
            EstadoRequerimiento = EstadoRequerimiento.Ingresado;
            //Informamos el ingreso al IGestorServicios
            GestorServicios.IngresarRequerimiento(datosIngresarRequerimiento);
            //Generamos y retornamos un evento de limiteAbandono
            return new EventoLimiteAbandono(DtIngreso.AddMinutes(20), this); //TODO sorteo. Esto podria tener una logica diferente para cada tipo de requerimiento
        }
        public virtual void EvaluarAbandono(IDatosProcesarLimiteAbandono datosProcesarLimiteAbandono)
        {
            var eventoLimite = datosProcesarLimiteAbandono.EventoOrigen;
            var requerimiento = (IReqServicio)eventoLimite.Requerimiento;
            var fecha = datosProcesarLimiteAbandono.EventoOrigen.Fecha;
            //Validarmos si aplica el abandono, ya que el requerimiento puede estar siendo atendido o haber finalizado
            if (requerimiento.EstadoRequerimiento == EstadoRequerimiento.Ingresado)
            {
                //Actualizamos estado del reque
                DtAbandono = eventoLimite.Fecha;
                EstadoRequerimiento = EstadoRequerimiento.Abandonado;
                //Informamos el evento al IGestorServicios
                GestorServicios.ProcesarLimiteAbandono(datosProcesarLimiteAbandono);
            }
        }
        public virtual IEventoRequerimiento IniciarRequerimiento(IPropuestaServicio propuestaServicio)
        {
            //Extraemos datos
            var fecha = propuestaServicio.DtFin;
            var prestador = propuestaServicio.Prestador;
            if (propuestaServicio.Requerimiento == this)
            {
                //Modificamos estado
                DtInicio = fecha;
                Prestador = (IPrestadorClientes)prestador;
                EstadoRequerimiento = EstadoRequerimiento.Iniciado;
                //Informamos al Gestor
                GestorServicios.IniciarRequerimiento(this);
                //Generamos evento de fin y lo retornamos.
                var eventoFin = new EventoFinRequerimiento(fecha, propuestaServicio.Requerimiento);
                return eventoFin;
            }
            else throw new ArgumentException("El requerimiento de la propuesta no coincide con el requerimiento que se pretende iniciar.");
        }
        public abstract List<IEvento> FinalizarRequerimiento(IDatosFinalizarRequerimiento datosFinalizarRequerimiento);

        public void EvaluarAbandono(DateTime dtEvaluarAbandono)
        {
            throw new NotImplementedException();
        }

        public void Ingresar(DateTime dtIngreso)
        {
            EstadoRequerimiento = EstadoRequerimiento.Ingresado;
            DtIngreso = dtIngreso;
            GestorServicios.IngresarRequerimiento(this);
            //Generamos un evento de limiteAbandono para el requerimiento

        }

        public void Iniciar(IPropuestaServicio propuestaServicio)
        {
            throw new NotImplementedException();
        }

        public void Finalizar(DateTime dtFin)
        {
            throw new NotImplementedException();
        }
    }
}
