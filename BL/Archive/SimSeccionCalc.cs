using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BL
{
    /*
    public partial class SimSeccionCalc : IGestorPrestadores, IGestorServicios
    {
        #region Properties
        private List<SimDemandaCalc> _Fila { get; set; }
        private List<SimDemandaCalc> _ListSimDemandaCalculadaEgresadas { get; set; }
        private SimSeccion _SimSeccionModel { get; set; }
        public List<IPrestador> Prestadores { get; }
        public IGestorServicios NodoPadre
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
        public List<IGestorServicios> NodosHijos
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        #endregion

        public SimSeccionCalc(IGestorServicios nodoPadre, SimSeccion simSeccionModel)
        {
            _Fila = new List<SimDemandaCalc>();
            _ListSimDemandaCalculadaEgresadas = new List<SimDemandaCalc>();
            SimSiteCalc = simSiteCalc;
            _SimSeccionModel = simSeccion;
            SimSiteCalc.VincularActionIEvento(_RecibirEventoSinResponder);
            SimSiteCalc.VincularPrestador(_RecibirSolicitud);
        }


        public void IngresarDemanda(EventoIRequerimientoArgs eventoIngreso)
        {
            eventoIngreso.SimDemandaCalc.IngresarPrestacion(eventoIngreso);
            _Fila.Add(eventoIngreso.SimDemandaCalc);
        }
        public void EgresarDemanda(EventoFinServicio eventoFinServicio)
        {
            //Ejecutamos funcion en la SimDemandaCalc correspondiente
            eventoFinServicio.SimDemandaCalc.FinalizarConsumo(eventoFinServicio);
            //Agregamos la demanda a la lista de egresos
            _ListSimDemandaCalculadaEgresadas.Add(eventoFinServicio.SimDemandaCalc);
            //Quitamos la demanda de la fila de seccion
            _Fila.Remove(eventoFinServicio.SimDemandaCalc);
        }
        public void AbandonarDemanda(EventoLimiteAbandono eventoLimiteAbandono)
        {
            //Si aplica, ejecutamos la funcion correspondiente, agregamos la demanda a la lista de egresos y quitamos de la fila
            if(eventoLimiteAbandono.SimDemandaCalc.DtEgreso == null)
            {
                eventoLimiteAbandono.SimDemandaCalc.AbandonarConsumo(eventoLimiteAbandono);
                _ListSimDemandaCalculadaEgresadas.Add(eventoLimiteAbandono.SimDemandaCalc);
                _Fila.Remove(eventoLimiteAbandono.SimDemandaCalc);
            }                
        }
        public Propuesta ProponerServicio(Propuesta propuestaRequerida)
        {            
            //TODO modificar esta forma de elegir la propuesta de proxima atencion para la seccion porque no cierra.
            if(_Fila.Count() > 0)
            {          
                //TODO seleccionar mejor propuesta de la seccion para enviar
                var proximaDemandaSeccion = _Fila.OrderBy(x => x.DtIngreso).FirstOrDefault();
                var propuestaDefinida = new Propuesta(proximaDemandaSeccion, propuestaRequerida.Fecha);
                //TODO aca hay que trabajar sobre la planificacion, porque no podemos elegir asi de simple.


                var mejorPropuesta = ListSimOfertaCalc
                                                .Select(x => x.OfrecerPropuesta(propuestaDefinida))
                                                .Where(x => x.SimDemandaCalc != null)
                                                .Where(x => x.SimOfertaCalc != null)
                                                .OrderBy(x => x.Costo).FirstOrDefault();
                return mejorPropuesta;
            }
            else
            {
                return new Propuesta();
            }
        }
        public void PrestarServicio(Propuesta propuestaSeleccionada)
        {
            //Ejecutamos metodo en demanda
            propuestaSeleccionada.SimDemandaCalc.IniciarConsumo(propuestaSeleccionada, ProfundidadFila(), OfertasActivas());
            //Ejecutamos metodo en oferta
            propuestaSeleccionada.SimOfertaCalc.IniciarPrestacionServicio(propuestaSeleccionada);

        }
        public int ProfundidadFila()
        {
            return _Fila.Count();
        }
        public int OfertasActivas()
        {
            return SimOfertaICollection.Where(x => x.OfertaActiva()).Count();
        }

        public void AgregarPrestador(IPrestador prestador)
        {
            throw new NotImplementedException();
        }
        public void RemoverPrestador(IPrestador prestador)
        {
            throw new NotImplementedException();
        }
        public void IngresarPrestacion(IEvento prestacion)
        {
            throw new NotImplementedException();
        }
        public void AbandonarPrestacion(IEvento prestacion)
        {
            throw new NotImplementedException();
        }
        public void IniciarPrestacion(IRequerimiento prestacion)
        {
            throw new NotImplementedException();
        }
        public void FinalizarPrestacion(IRequerimiento prestacion)
        {
            throw new NotImplementedException();
        }
        public IRequerimiento ProponerServicio(IRequerimiento propuesta)
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
        public IInterrupcion EvaluarInterrupcion()
        {
            throw new NotImplementedException();
        }
        public void IniciarSoporte(IRequerimiento soporte)
        {
            throw new NotImplementedException();
        }
        public void FinalizarSoporte(IRequerimiento soporte)
        {
            throw new NotImplementedException();
        }
        public IRequerimiento ProponerSoporte(IRequerimiento soporte)
        {
            throw new NotImplementedException();
        }
        public void AgregarNodoHijo(IGestorServicios nodo)
        {
            throw new NotImplementedException();
        }
        public void RemoverNodoHijo(IGestorServicios nodo)
        {
            throw new NotImplementedException();
        }
    }
    */
}
