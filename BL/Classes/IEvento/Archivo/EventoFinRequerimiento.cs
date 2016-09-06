using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    //public class EventoFinRequerimiento : IEventoRequerimiento
    //{
    //    public IRequerimiento Requerimiento { get; set; }
    //    public DateTime Fecha { get; set; }
    //    public EventoFinRequerimiento(DateTime fecha, IRequerimiento requerimiento)
    //    {
    //        Fecha = fecha;
    //        Requerimiento = requerimiento;
    //    }
    //    public void ProcesarEvento(ISimulador simulador)
    //    {
    //        var datosFin = new DatosFinalizarRequerimientoBanca(this);

    //        //Ejecutamos metodo para que finalice el requerimiento correspondiente y notifique a su prestador y gestor de servicios
    //        var eventoFeedback = Requerimiento.FinalizarRequerimiento(datosFin);
    //        if (eventoFeedback != null)
    //        {
    //            foreach (var ef in eventoFeedback)
    //            {
    //                simulador.FilaEventos.Agregar(ef);
    //            }
    //        }
    //        //Archivamos el evento
    //        simulador.FilaEventos.Archivar(this);
    //    }
    //}
}
