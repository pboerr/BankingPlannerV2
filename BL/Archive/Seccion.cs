using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    /*
    public class Seccion : INodo, IGestorServicios
    {
        #region INodo - IGestorServicios
        public INodo NodoPadre { get; set; }
        public List<INodo> NodosHijos { get; }
        public void AgregarNodoHijo(INodo nodo)
        {
            NodosHijos.Add(nodo);
        }
        public void RemoverNodoHijo(INodo nodo)
        {
            NodosHijos.Remove(nodo);
        }

        public EventoIRequerimientoArgs IngresarRequerimiento(EventoIRequerimientoArgs eventoIngresoRequerimiento)
        {
            //Agregamos el requerimiento nuevo a la fila de espera
            _FilaEsperaRequerimientos.Add(eventoIngresoRequerimiento.Requerimiento);
            //Modificamos el estado del requerimiento    
            eventoIngresoRequerimiento.Requerimiento.IngresarRequerimiento(eventoIngresoRequerimiento.Fecha);
            //Generamos el evento de limite para abandono. TODO falta sortear el tiempo maximo de espera que tolera el requerimiento
            return new EventoIRequerimientoArgs(eventoIngresoRequerimiento.Fecha.AddMinutes(20), TipoEvento.LimiteAbandono);
        }
        public void ProcesarAbandonoRequerimiento(EventoIRequerimientoArgs eventoLimiteAbandono)
        {
            //Validarmos si aplica el abandono, ya que el requerimiento puede estar siendo atendido o haber finalizado
            if (eventoLimiteAbandono.Requerimiento.EstadoRequerimiento == EstadoRequerimiento.Ingresado)
            {
                //Modificamos el estado del requerimiento
                eventoLimiteAbandono.Requerimiento.AbandonarRequerimiento(eventoLimiteAbandono.Fecha);
                //Agregamos el requerimiento a los finalizados
                _RequerimientosFinalizados.Add(eventoLimiteAbandono.Requerimiento);
                //Quitamos el requerimiento de la fila
                _FilaEsperaRequerimientos.Remove(eventoLimiteAbandono.Requerimiento);
            }
        }
        public IPropuesta ProponerRequerimiento(DateTime fecha)
        {
            throw new NotImplementedException();
        }
        public void IniciarRequerimiento(IPropuesta propuestaSeleccionada)
        {
            throw new NotImplementedException();
            //Quitar de fila espera
        }
        public void FinalizarRequerimiento(EventoIRequerimientoArgs eventoFinServicio)
        {
            //Modificamos el estado del requerimiento
            eventoFinServicio.Requerimiento.FinalizarRequerimiento(eventoFinServicio.Fecha);
            //Quitamos el requerimiento de la fila
            _FilaEsperaRequerimientos.Remove(eventoFinServicio.Requerimiento);
            //Agregamos el requerimiento a los finalizados
            _RequerimientosFinalizados.Add(eventoFinServicio.Requerimiento);
        }

        public ISoporte ProponerSoporte(ISoporte soporte)
        {
            throw new NotImplementedException();
        }
        public void IniciarSoporte(ISoporte soporte)
        {
            throw new NotImplementedException();
        }
        public void FinalizarSoporte(ISoporte soporte)
        {
            throw new NotImplementedException();
        }

        public void EvaluarInterrupcion()
        {
            throw new NotImplementedException();
        }
        public void IniciarInterrupcion(IInterrupcion interrupcion)
        {
            throw new NotImplementedException();
        }
        public void FinalizarInterrupcion(IInterrupcion interrupcion)
        {
            throw new NotImplementedException();
        }

        public void IniciarMovimiento(IMovimiento movimiento)
        {
            throw new NotImplementedException();
        }
        public void FinalizarMovimiento(IMovimiento movimiento)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Metodos y propiedades INodo
        List<IRequerimiento> _FilaEsperaRequerimientos;
        List<IRequerimiento> _RequerimientosFinalizados;
        #endregion
    }
    */
}
