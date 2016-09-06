using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class EventoIngresoVisita : IEvento
    {
        public IVisita Visita { get; private set; }
        public ISimulador Simulador { get; private set; }
        public DateTime Fecha { get; private set; }

        public EventoIngresoVisita(ISimulador simulador, IVisita visita)
        {
            Simulador = simulador;
            Visita = visita;
            Fecha = visita.DtIngreso;
        }

        public void Procesar()
        {
            //Ingresamos esta visita y archivamos el evento
            Visita.Ingresar(Fecha);
            Simulador.FilaEventos.Archivar(this);

            //Ingresamos el evento de la siguiente visita
            if (Simulador.FilaVisitas.Count > 0)
            {
                var proximaVisita = Simulador.FilaVisitas.Dequeue();
                Simulador.FilaEventos.Agregar(new EventoIngresoVisita(Simulador, proximaVisita));
            }
        }
    }
}
