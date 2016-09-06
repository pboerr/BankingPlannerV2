using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Ubicacion : INodo, IGestorServicios, IGeneradorPropuestas
    {
        public Ubicacion()
        {
            FilaEsperaRequerimientos = new List<IRequerimiento>();
            RequerimientosFinalizados = new List<IRequerimiento>();
            NodosHijos = new List<INodo>();
        }

        #region INodo
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
        public IEnumerable<INodo> NodoYDescendientes(INodo nodoBase)
        {
            yield return nodoBase;
            foreach(INodo nodo in nodoBase.NodosHijos)
            {
                foreach(INodo n in NodoYDescendientes(nodo))
                {
                    yield return n;
                }
            }
        }
        #endregion

        #region IGestorServicios //No podemos modificar propiedades no vinculadas directamente con la interfaz.
        public List<IRequerimiento> FilaEsperaRequerimientos { get; private set; }
        public List<IRequerimiento> RequerimientosFinalizados { get; private set; }
        public int CantidadEspera()
        {
            return FilaEsperaRequerimientos.Count();
        }
        public void IngresarRequerimiento(IDatosIngresarRequerimiento datosIngresarRequerimiento)
        {
            //Agregamos el requerimiento del evento de ingreso en la fila de este IGestorServicios.
            FilaEsperaRequerimientos.Add(datosIngresarRequerimiento.EventoOrigen.Requerimiento);
        }
        public void ProcesarLimiteAbandono(IDatosProcesarLimiteAbandono datosProcesarLimiteAbandono)
        {
            var requerimiento = datosProcesarLimiteAbandono.EventoOrigen.Requerimiento;
            //Agregamos el reque a los finalizados
            RequerimientosFinalizados.Add(requerimiento);
            //Quitamos el requerimiento de la fila
            FilaEsperaRequerimientos.Remove(requerimiento);
        }
        public void IniciarRequerimiento(IRequerimiento requerimiento)
        {
            //Removemos el requerimiento de la fila de la ubicacion
            FilaEsperaRequerimientos.Remove(requerimiento);
        }
        public List<IEvento> FinalizarRequerimiento(IDatosFinalizarRequerimiento datosFinalizarRequerimiento)
        {
            var evento = (EventoFinRequerimiento)datosFinalizarRequerimiento.EventoOrigen;
            var reque = evento.Requerimiento;          
            var eventosFinRequerimiento = reque.FinalizarRequerimiento(datosFinalizarRequerimiento);
            RequerimientosFinalizados.Add(reque);
            return eventosFinRequerimiento;
        }
        #endregion

        #region IReceptor
        public List<IPropuestaServicio> ProponerRequerimiento(IDatosProponerRequerimiento datosProponer)
        {
            //Llega el pedido de propuesta al receptor, con o sin requerimientos "heredados".
            //De todas formas, se juntan con la fila de la ubicacion actual. 
            var listaAgregada = datosProponer.FilaEsperaRequerimientos
                                                .Concat(FilaEsperaRequerimientos)
                                                .ToList();

            //Una vez que tenemos todos los requerimientos actuales de la jerarquia, hacemos el pedido a los hijos.
            //Este tema nos permite definir requerimientos que estan acotados a un grupo de prestadores, y otros
            //que pueden tener alcance regional, etc.
            var hijosReceptores = NodosHijos.Where(x => x is IGeneradorPropuestas).Cast<IGeneradorPropuestas>().ToList();
            if(hijosReceptores != null)
            {
                var datosHijos = new DatosProponerRequerimientoBanca(datosProponer.Fecha, listaAgregada);               
                var propuestaSeleccionada = hijosReceptores
                                                    .SelectMany(x => x.ProponerRequerimiento(datosHijos))
                                                    .ToList(); 
                return propuestaSeleccionada;
            }
            else
            {
                return null;
            }           
        }
        public void EvaluarPosiblesInterrupciones(IDatosEvaluarPosiblesInterrupciones datosPosiblesInterrupciones)
        {
            //Como la ubicacion no es IInterrumpible, solamente solicita posibles interrupciones a sus hijos.
            var receptoresHijos = NodosHijos
                .Where(x => x is IGeneradorPropuestas)
                .Cast<IGeneradorPropuestas>();

            if (receptoresHijos != null)
            {
                foreach (var rp in receptoresHijos)
                {
                    rp.EvaluarPosiblesInterrupciones(datosPosiblesInterrupciones);
                }
            } 
        }
        #endregion

        


    }
}
