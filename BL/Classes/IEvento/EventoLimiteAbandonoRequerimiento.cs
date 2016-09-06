using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class EventoLimiteAbandonoRequerimiento : IEvento
    {
        public IReqServicio Requerimiento { get; private set; }
        public DateTime Fecha { get; private set; }
        public ISimulador Simulador { get; private set; }

        public EventoLimiteAbandonoRequerimiento(IReqServicio requerimiento, DateTime fecha, ISimulador simulador)
        {
            Requerimiento = requerimiento;
            Fecha = fecha;
            Simulador = simulador;
        }

        public void Procesar()
        {
            Requerimiento.EvaluarAbandono(Fecha);
            Simulador.FilaEventos.Archivar(this);
        }
    }
}
