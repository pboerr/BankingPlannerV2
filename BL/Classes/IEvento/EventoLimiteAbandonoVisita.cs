using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class EventoLimiteAbandonoVisita : IEvento
    {
        public IVisita Visita { get; private set; }
        public DateTime Fecha { get; private set; }
        public ISimulador Simulador { get; private set; }

        public EventoLimiteAbandonoVisita(IVisita visita, DateTime fecha, ISimulador simulador)
        {
            Visita = visita;
            Fecha = fecha;
            Simulador = simulador;
        }


        public void Procesar()
        {
            Visita.Accionar(Fecha);
            Simulador.FilaEventos.Archivar(this);
        }
    }
}
