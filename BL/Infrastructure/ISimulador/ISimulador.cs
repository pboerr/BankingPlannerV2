using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface ISimulador
    {

        //Por ahora tenemos una definicion preliminar de esta interfaz hasta que no construyamos otro tipo de simuladores.
        Fila<IVisita> FilaVisitas { get; }
        FilaEventos FilaEventos { get; }
        void Simular();
        void Planificar();

    }

    
}
