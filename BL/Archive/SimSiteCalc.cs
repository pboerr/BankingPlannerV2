using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BL
{
    /*
    public partial class SimSiteCalc : ISimulador, IGestorServicios
    {


        #region Properties
        Queue<SimDemandaCalc> _FilaLlegadas;
        private SimSite _SimSiteModel;
        private FilaEventos _FilaEventos;
        public IGestorServicios NodoPadre { get; set; }
        public List<IGestorServicios> NodosHijos { get; private set; }
        #endregion

        public SimSiteCalc(SimSite simSiteModel)
        {
            _FilaLlegadas = new Queue<SimDemandaCalc>();
            _FilaEventos = new FilaEventos();
            _SimSiteModel = simSiteModel;
            NodosHijos = new List<IGestorServicios>();           
        }
        public void IngresarEvento(IEvento evento)
        {
            _FilaEventos.Agregar(evento);
        }
        public void ArchivarEvento(IEvento evento)
        {
            _FilaEventos.Archivar(evento);
        }
        public void AgregarNodoHijo(IGestorServicios nodo)
        {
            NodosHijos.Add(nodo);
        }
        public void RemoverNodoHijo(IGestorServicios nodo)
        {
            NodosHijos.Remove(nodo);
        }

        #region Metodos simulacion
        private void _GenerarPrimerEvento()
        {
            var proxDemanda = _FilaLlegadas.Dequeue();
            IngresarEvento(new EventoIRequerimientoArgs(proxDemanda.DtIngreso, proxDemanda, TipoEvento.IngresoRequerimiento));
        }
        private void _IngresarDemanda(EventoIRequerimientoArgs eventoIngreso)
        {
            //Ejecutamos funcion en la seccion correspondiente
            eventoIngreso.SimDemandaCalc.SimSeccionCalc.IngresarDemanda(eventoIngreso);            
            //Generamos un evento para el proximo ingreso y lo agregamos a la fila
            if (_FilaLlegadas.Count() > 0)
            {
                var proxDemanda = _FilaLlegadas.Dequeue();
                IngresarEvento(new EventoIRequerimientoArgs(proxDemanda.DtIngreso, proxDemanda, TipoEvento.IngresoRequerimiento));
            }
            //Quitamos el evento de la fila
            ArchivarEvento(eventoIngreso);
        }      
        private void _ProcesarLimiteAbandono(EventoLimiteAbandono eventoLimiteAbandono)
        {
            //Ejecutamos funcion en la seccion correspondiente
            eventoLimiteAbandono.SimDemandaCalc.SimSeccionCalc.AbandonarDemanda(eventoLimiteAbandono);
            //Quitamos el evento de la fila
            ArchivarEvento(eventoLimiteAbandono);
        }
        private void _IniciarProximoServicioPosible(Propuesta requerimiento)
        {
            //Identificamos la siguiente propuesta. Logica de seleccion en secciones.
            //TODO mejor el criterio de planificacion, porque estamos eligiendo FIFO y no es suficiente.   

            var propuestaSeleccionada = NodosHijos
                                                .Select(x => x.ProponerServicio(requerimiento))
                                                .Where(x => x.SimDemandaCalc != null)
                                                .Where(x => x.SimOfertaCalc != null)
                                                .OrderBy(x => x.SimDemandaCalc.DtIngreso)
                                                .FirstOrDefault();

            if (propuestaSeleccionada != null)
            {
                propuestaSeleccionada.SimDemandaCalc.SimSeccionCalc.PrestarServicio(propuestaSeleccionada);
                IngresarEvento(new EventoFinServicio(propuestaSeleccionada.SimDemandaCalc.DtEgreso, propuestaSeleccionada.SimDemandaCalc, TipoEvento.FinRequerimiento));
            }
        }
        private void _EgresarDemanda(EventoFinServicio eventoFinServicio)
        {
            //Ejecutamos funcion en la seccion correspondiente
            eventoFinServicio.SimDemandaCalc.SimSeccionCalc.EgresarDemanda(eventoFinServicio);
            //Quitamos el evento de la fila
            ArchivarEvento(eventoFinServicio);
        }

        private void _ProcesarProximasInterrupcionesPorTipo()
        {
            //disparamos el sorteo de interrupciones a todas las ofertas del site en cada una de sus secciones.
        }     
        private void _IniciarProximaInterrupcion()
        {
            throw new NotImplementedException();
        }
        private void _FinalizarProximaInterrupcion()
        {
            throw new NotImplementedException();
        }
        private void _IniciarProximoSoporte()
        {
            //TODO aca generamos evento de fin proxima interrupcion
        }
        private void _FinalizarProximoSoporte()
        {
            throw new NotImplementedException();
        }

        #endregion

        public void Simular() //TODO usar delegates para desacoplar este switch
        {
            _GenerarPrimerEvento(); //Iniciamos loop

            while (_FilaEventos.Activa)
            {
                IEvento EventoActual = _FilaEventos.ProximoEvento();

                switch (EventoActual.TipoEvento)
                {
                    case TipoEvento.IngresoRequerimiento:
                        {
                            _IngresarDemanda(EventoActual as EventoIRequerimientoArgs);
                            break;
                        }
                    case TipoEvento.LimiteAbandono:
                        {
                            _ProcesarLimiteAbandono(EventoActual as EventoLimiteAbandono);
                            break;
                        }
                    case TipoEvento.FinRequerimiento:
                        {
                            _EgresarDemanda(EventoActual as EventoFinServicio);
                            break;
                        }
                    case TipoEvento.InicioInterrupcion:
                        {
                            _IniciarProximaInterrupcion();
                            break;
                        }
                    case TipoEvento.FinInterrupcion:
                        {
                            _FinalizarProximaInterrupcion();
                            break;
                        }
                    case TipoEvento.InicioSoporte:
                        {
                            _IniciarProximoSoporte();
                            break;
                        }
                    case TipoEvento.FinSoporte:
                        {
                            _FinalizarProximoSoporte();
                            break;
                        }
                    default: break;
                }

                //A partir de cualquier evento, calculamos interrupciones y proximo servicio.
                _ProcesarProximasInterrupcionesPorTipo();
 
                _IniciarProximoServicioPosible(new Propuesta(EventoActual.Fecha));
            }

        }


    }
    */
}
