using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class SimuladorBanca : ISimulador
    {
        //Aca estamos diciendo que para una ubicacion cualquiera, podemos elegir que tipo de simulador vamos a utilizar.
        public Fila<IVisita> FilaVisitas { get; private set; }
        public FilaEventos FilaEventos { get; private set; }
        public SimuladorBanca(Fila<IVisita> filaVisitas, FilaEventos filaEventos)
        {
            FilaVisitas = filaVisitas;
            FilaEventos = filaEventos; //podriamos querer comenzar la simulacion con eventos encolados
        }

        public void Simular()
        {
            //Generamos el primer evento en la _FilaEventos para activar el while
            if (FilaVisitas.Count > 0)
            {
                var proximaVisita = FilaVisitas.Dequeue();
                FilaEventos.Agregar(new EventoIngresoVisita(this, proximaVisita));
            }

            //Mientras la _FilaEventos se encuentre activa...
            while (FilaEventos.Activa)
            {
                //Capturamos el proximo evento y ejecutamos el metodo ProcesarEvento() porque las acciones a seguir
                //corresponden a cada clase de evento.
                IEvento EventoActual = FilaEventos.ProximoEvento();
                EventoActual.Procesar();
                //Calculamos interrupciones y proximo servicio.
                Planificar();
            }
        }
        public void Planificar()
        {
            //busco 
        }

        //public void IniciarProximoServicioPosible(IDatosProximoServicioPosible datosProximoServicioPosible)
        //{
        //    //Extraigo la info que necesito
        //    var fecha = datosProximoServicioPosible.Fecha;
        //    //Pedimos una lista de todas las propuestas a cada receptor principal (i.e. sites). Este pedido baja en cascada.
        //    var propuestasRecibidas = ReceptoresPrimarios.SelectMany(x => x.ProponerRequerimiento(new DatosProponerRequerimientoBanca(fecha))).ToList();
            
        //    if(propuestasRecibidas != null)
        //    {
        //        //elegimos la propuesta ganadora
        //        var propuestaSeleccionada = SeleccionarPropuesta(propuestasRecibidas);
        //        //iniciamos requerimientos y agregamos evento fin
        //        var gestorServicios = propuestaSeleccionada.Requerimiento.GestorServicios;
        //        var eventoFin = propuestaSeleccionada.IniciarPropuesta();
        //        //modificamos estado propuesta
        //        FilaEventos.Agregar(eventoFin);
        //    }
        //    /*
        //     NOTAS
        //     Llamamos al metodo IniciarRequerimiento del IGestorServicios porque debe actualizar su fila espera antes de 
        //     pasarle la orden de inicio al prestador. 
        //     Que hacemos si no hay nada que pueda comenzar ahora?
        //        No hacemos nada, y el loop continua con el proximo evento.
        //     Que pasa si un requerimiento en fila (soporte o servicio) no tiene nunca nadie que lo pueda atender?
        //        Los de servicio, tarde o temprano abandonar, cuando llegue el evento correspondiente.
        //        Los de soporte, deberian quedar en fila cuando termine la simulacion. Por supuesto, los prestadores afectados 
        //        tambien quedan con el estado interrumpido al final de la simulacion.
        //     */

        //}
        //public void EvaluarPosiblesInterrupciones(IDatosEvaluarPosiblesInterrupciones datosPosiblesInterrupciones)
        //{     
        //    foreach(var rp in ReceptoresPrimarios)
        //    {
        //        rp.EvaluarPosiblesInterrupciones(datosPosiblesInterrupciones);
        //    }    
        //}
        //public IPropuestaServicio SeleccionarPropuesta(List<IPropuestaServicio> propuestasServicio)
        //{
        //    //TODO queda pendiente como implementar plani menos miope
        //    //TODO de corto plazo, tenemos que incorporar las reglas del nemoQ
        //    var output = propuestasServicio.OrderByDescending(x => x.Requerimiento.DtIngreso).FirstOrDefault();
        //    return output;
        //}
    
    }
}
