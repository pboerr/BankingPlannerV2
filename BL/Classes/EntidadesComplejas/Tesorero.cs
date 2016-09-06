using System;
using System.Collections.Generic;
using System.Linq;

namespace BL
{
    //public class Tesorero : INodoArbol, IPrestadorSoporte, IPrestadorClientes, IReceptor, IInterrumpible,
    //                        IPrestadorExtraccionEfectivo, IPrestadorDepositoEfectivo, IPrestadorDepositoSobres,
    //                        IPrestadorDepositoCheques
    //{
    //    public Tesorero()
    //    {
    //        EstadoPrestador = EstadoPrestador.Disponible;
    //        NodosHijos = new List<INodoArbol>();
    //        TiposRequerimientoHabilitados = new HashSet<ITipoRequerimiento>();
    //        SolicitantesHabilitados = new HashSet<IPrestadorClientes>();
    //        UltimasInterrupcionesGeneradas = new List<IInterrupcion>();
    //        _TotalOperaciones = 0;
    //        _EfectivoDisponible = 0;
    //        _MinutosPrestandoServicio = 0;
    //    }
    //    public Tesorero(EstadoPrestador estadoPrestador, List<INodoArbol> nodosHijos,
    //                HashSet<ITipoRequerimiento> tiposRequerimientoHabilitados, HashSet<IPrestadorClientes> solicitantesHabilitados,
    //                INodoArbol nodoPadre = null)
    //    {
    //        EstadoPrestador = estadoPrestador;
    //        NodosHijos = nodosHijos;
    //        TiposRequerimientoHabilitados = tiposRequerimientoHabilitados;
    //        SolicitantesHabilitados = solicitantesHabilitados;
    //    }

    //    #region INodo
    //    public INodoArbol NodoPadre { get; set; }
    //    public List<INodoArbol> NodosHijos { get; }
    //    public void AgregarNodoHijo(INodoArbol nodo)
    //    {
    //        NodosHijos.Add(nodo);
    //    }
    //    public void RemoverNodoHijo(INodoArbol nodo)
    //    {
    //        NodosHijos.Remove(nodo);
    //    }
    //    #endregion

    //    #region IReceptor
    //    public List<IPropuestaServicio> ProponerRequerimiento(IDatosProponerRequerimiento datosProponer)
    //    {
    //        //var prestador = (IPrestadorClientes)this;
    //        //return prestador.ProponerRequerimiento(datosProponer);
    //        //para cada requerimiento en la lista, si puedo hacer algo, genero una propuesta y la agrego.
    //        //Validamos que el prestador se encuentre disponible
    //        if (EstadoPrestador == EstadoPrestador.Disponible)
    //        {
    //            var fechaPropuesta = datosProponer.Fecha;
    //            List<IRequerimiento> listaPosibilidades = new List<IRequerimiento>();
    //            List<IPropuestaServicio> listaPropuestas = new List<IPropuestaServicio>();

    //            //Primero evaluamos todas las posibles prestaciones para Requerimientos de Servicio
    //            var requerimientosServicio = datosProponer.FilaEsperaRequerimientos.Where(x => x is IReqServicio).Cast<IReqServicio>();

    //            //Identifico los requerimientos que aplican por tipo de cliente y tipo de requerimiento
    //            var alternativasReqServicio = from req in requerimientosServicio
    //                                          join tc in TiposClienteHabilitados on req.TipoCliente equals tc
    //                                          join tr in TiposRequerimientoHabilitados on req.TipoRequerimiento equals tr
    //                                          select req;

    //            foreach (var alt in alternativasReqServicio)
    //            {
    //                listaPosibilidades.Add(alt);
    //            }

    //            //En segundo lugar evaluamos los posibles soportes
    //            var requerimientosSoporte = datosProponer.FilaEsperaRequerimientos.Where(x => x is IReqSoporte).Cast<IReqSoporte>();
    //            var alternativasReqSoporte = from req in requerimientosSoporte
    //                                         join sol in SolicitantesHabilitados on req.Solicitante equals sol //nodos implicitos
    //                                         select req;
    //            foreach (var alt in alternativasReqSoporte)
    //            {
    //                listaPosibilidades.Add(alt);
    //            }


    //            //RETURN
    //            if (listaPosibilidades.Count > 0)
    //            {
    //                foreach (var pos in listaPosibilidades)
    //                {
    //                    //TODO necesitamos una funcion costo para evaluar 
    //                    //TODO tenemos que sortear la duracion 
    //                    listaPropuestas.Add(new PropuestaServicio(pos, this, EstadoPropuesta.Pendiente, fechaPropuesta, fechaPropuesta.AddMinutes(60), 10));
    //                }

    //            }
    //            return listaPropuestas;
    //        }
    //        else
    //        {
    //            return null;
    //        }
    //    }
    //    public List<IEvento> EvaluarPosiblesInterrupciones(IDatosEvaluarPosiblesInterrupciones datosPosiblesInterrupciones)
    //    {
    //        List<IEvento> output = new List<IEvento>();
    //        //Sorteamos las interrupciones que apliquen a este ATM y vemos si se interrumpe ahora o no
    //        IRequerimiento requeSoporte = EvaluarPosibleInterrupcion(datosPosiblesInterrupciones);
    //        //TODO Ademas, solicitamos a sus hijos IReceptores, que sorteen sus propias interrupciones
    //        //En el caso de ATM no vamos a usar inicialmente interrupciones en los modulos porque no escribimos las clases correspondientes.
    //        //Juntamos los dos resultados y los retornamos
    //        if (requeSoporte != null)
    //        {
    //            output.Add(new EventoIRequerimientoArgs(datosPosiblesInterrupciones.Fecha, requeSoporte, TipoEvento.IngresoRequerimiento));
    //            return output;
    //        }
    //        else return null;
    //    }
    //    #endregion

    //    #region IPrestadorSoporte
    //    #region IPrestador - Proponer
    //    public IGestorServicios GestorServicios
    //    {
    //        get
    //        {
    //            if (NodoPadre is IGestorServicios)
    //            {
    //                return (IGestorServicios)NodoPadre;
    //            }
    //            //TODO aca nos queda pendiente implementar busqueda de gestor de servicios
    //            else return null;
    //        }

    //    }
    //    public EstadoPrestador EstadoPrestador { get; private set; }
    //    public IPropuestaServicio PropuestaServicio { get; private set; }
    //    public HashSet<ITipoCliente> TiposClienteHabilitados { get; private set; }
    //    public void AgregarTipoCliente(ITipoCliente tipoCliente)
    //    {
    //        TiposClienteHabilitados.Add(tipoCliente);
    //    }
    //    public void RemoverTipoCliente(ITipoCliente tipoCliente)
    //    {
    //        TiposClienteHabilitados.Remove(tipoCliente);
    //    }
    //    public HashSet<IPrestadorClientes> SolicitantesHabilitados { get; private set; }
    //    public void AgregarSolicitanteHabilitado(IPrestadorClientes solicitante)
    //    {
    //        SolicitantesHabilitados.Add(solicitante);
    //    }
    //    public void RemoverSolicitanteHabilitado(IPrestadorClientes solicitante)
    //    {
    //        SolicitantesHabilitados.Remove(solicitante);
    //    }
    //    public HashSet<ITipoRequerimiento> TiposRequerimientoHabilitados { get; private set; }
    //    public void AgregarTipoRequerimiento(ITipoRequerimiento tipoRequerimiento)
    //    {
    //        TiposRequerimientoHabilitados.Add(tipoRequerimiento);
    //    }
    //    public void RemoverTipoRequerimiento(ITipoRequerimiento tipoRequerimiento)
    //    {
    //        TiposRequerimientoHabilitados.Remove(tipoRequerimiento);
    //    }
    //    #endregion
    //    #region IPrestador - Iniciar
    //    public IEventoFinRequerimiento IniciarRequerimiento(IPropuestaServicio propuesta)
    //    {
    //        //Actualizamos el estado del prestador
    //        EstadoPrestador = EstadoPrestador.PrestandoServicio;
    //        PropuestaServicio = propuesta;
    //        //Aceptamos la propuesta que dispara el inicio del requerimiento
    //        var eventoFin = propuesta.IniciarPropuesta();
    //        //Retornamos evento de FinRequerimiento
    //        return eventoFin;
    //    }
    //    #endregion
    //    #region IPrestador - Finalizar
    //    public List<IEvento> EntregarEfectivo(int cantidadEfectivo, DateTime fecha)
    //    {
    //        //Actualizo propiedades del objeto
    //        _EfectivoDisponible -= cantidadEfectivo;
    //        _TotalOperaciones++;
    //        //Generamos acciones y colectamos eventos para devolver
    //        List<IEvento> outputList = new List<IEvento>();
    //        if (_EfectivoDisponible < 0)
    //        {
    //            //Iniciamos la interrupcion directamente
    //            var interrupcionDisponibilidadEfectivo = new InterrupcionDisponibilidadEfectivo(fecha, this);
    //            var requeSoporte = interrupcionDisponibilidadEfectivo.IniciarInterrupcion();

    //            //var requeSoporte = IniciarInterrupcion(new InterrupcionBanca(fecha, new TipoInterrupcionBanca("DisponibilidadEfectivo"), new TipoRequerimientoBanca(TipoRequerimiento.SoporteTesoro)));
    //            //Generamos el ingreso de un requerimiento de soporte
    //            //TODO sortear cantidad de efectivo a ser abastecido
    //            //var requeSoporte = new AbastecimientoEfectivo(eventoFin.Fecha, gestorServicios, this, 1000);
    //            outputList.Add(new EventoIngresoRequerimiento(fecha, requeSoporte));
    //        }
    //        if (outputList != null)
    //        {
    //            return outputList;
    //        }
    //        else return null;
    //    }
    //    public void DepositarCheques(int cantidadCheques)
    //    {

    //    }
    //    public void DepositarEfectivo(int cantidadEfectivo)
    //    {

    //    }
    //    public void DepositarSobres(int cantidadSobres)
    //    {

    //    }
    //    public void ResponderConsulta()
    //    {

    //    }
    //    public List<IEvento> FinalizarRequerimiento(IDatosFinalizarRequerimiento datosFinalizarRequerimiento)
    //    {

    //        List<IEvento> outputList = new List<IEvento>();
    //        //Modificamos estados
    //        EstadoPrestador = EstadoPrestador.Disponible;
    //        PropuestaServicio = null;
    //        var eventoFin = (EventoIRequerimientoArgs)datosFinalizarRequerimiento.EventoOrigen;
    //        var gestorServicios = eventoFin.Requerimiento.GestorServicios;
    //        //Este enfoque es clave, ya que la logica depende del tipo de requerimiento.
    //        var eventosResultantes = eventoFin.Requerimiento.FinalizarRequerimiento(datosFinalizarRequerimiento);
    //        return eventosResultantes;

    //    }
    //    #endregion
    //    #endregion

    //    #region IInterrumpible
    //    public IInterrupcion Interrupcion { get; private set; }
    //    public List<IInterrupcion> UltimasInterrupcionesGeneradas { get; private set; }
    //    public IRequerimiento IniciarInterrupcion(IInterrupcion interrupcion)
    //    {
    //        Interrupcion = interrupcion;
    //        EstadoPrestador = EstadoPrestador.Interrumpido;
    //        //Removemos cualquier caso del mismo tipo de interrupcion asi nos queda siempre el ultimo solamente
    //        UltimasInterrupcionesGeneradas.RemoveAll(x => x.TipoInterrupcion == interrupcion.TipoInterrupcion);
    //        //Agregamos la interrupcion
    //        UltimasInterrupcionesGeneradas.Add(interrupcion);
    //    }
    //    public void FinalizarInterrupcion(IInterrupcion interrupcion)
    //    {
    //        Interrupcion = null;
    //        EstadoPrestador = EstadoPrestador.Disponible;
    //    }
    //    public IRequerimiento EvaluarPosibleInterrupcion(IDatosEvaluarPosiblesInterrupciones datosPosiblesInterrupciones)
    //    {
    //        if (EstadoPrestador != EstadoPrestador.Interrumpido)
    //        {
    //            //Sorteamos teniendo en cuenta el estado de los contadores                
    //            //En otros casos necesitamos conocer las ultimas interrupciones por tipo (IInterrumpible)
    //            //TODO aca falta toda la logica de como validar que efectivamente debemos interrumpir el ATM.
    //            if (TotalOperaciones > 100)
    //            {
    //                var nuevaInt = new InterrupcionBanca(datosPosiblesInterrupciones.Fecha, new TipoInterrupcionBanca(TipoInterrupcion.DisponibilidadEfectivo), new TipoRequerimientoBanca(TipoRequerimiento.SoporteTesoro));
    //                var nuevoReqSoporte = IniciarInterrupcion(nuevaInt);
    //                return nuevoReqSoporte;
    //            }
    //            else return null;
    //        }
    //        else
    //        {
    //            return null;
    //        }
    //    }


    //    #endregion

    //    #region Propiedades y metodos

    //    int _TotalOperaciones;
    //    int _EfectivoDisponible;
    //    int _MinutosPrestandoServicio;

    //    #endregion

}
