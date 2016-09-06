using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    //public class EventoIngresoRequerimiento : IEventoRequerimiento
    //{
    //    public ISimulador Simulador { get; private set; }
    //    public IRequerimiento Requerimiento { get; set; }
    //    public DateTime Fecha { get; set; }
    //    public EventoIngresoRequerimiento(DateTime fecha, IRequerimiento requerimiento)
    //    {
    //        Fecha = fecha;
    //        Requerimiento = requerimiento;
    //    }

    //    public void Procesar()
    //    {
    //        var datosIngreso = new DatosIngresarRequerimientoBanca(this);
    //        //Ordenamos el ingreso al IGestorServicios del requerimiento involucrado en el evento. 
    //        //Recibimos un evento de LimiteAbandono que agregamos a la fila de eventos.
    //        var eventoLimiteAbandono = Requerimiento.IngresarRequerimiento(datosIngreso);
    //        if (eventoLimiteAbandono != null)
    //        {
    //            simulador.FilaEventos.Agregar(eventoLimiteAbandono);
    //        }
    //        //Si hay requerimientos de servicio en espera, ingresamos el proximo.
    //        if (simulador.FilaVisitas.Count > 0)
    //        {
    //            var proxDemanda = simulador.FilaVisitas.Dequeue();
    //            simulador.FilaEventos.Agregar(new EventoIngresoRequerimiento(proxDemanda.DtIngreso, proxDemanda));
    //        }
    //        //Por ultimo, archivamos el evento de ingreso original.
    //        simulador.FilaEventos.Archivar(this);

    //    }
    //}
}
