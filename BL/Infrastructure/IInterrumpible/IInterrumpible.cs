using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IInterrumpible
    {   
        //Propiedades relacionadas con interrupciones pre cargadas o sorteos por lote.
        Queue<IInterrupcion> FilaInterrupciones { get; }
        void AgregarInterrupciones(List<IInterrupcion> interrupciones);
        bool SorteaInterrupciones { get; set; }

        List<IInterrupcion> UltimasInterrupcionesPorTipo { get; } //por tipo  
        IInterrupcion InterrupcionActual { get; }
        void IniciarInterrupcion(IInterrupcion interrupcion); //retornaba IRequerimiento
        void FinalizarInterrupcion(IInterrupcion interrupcion);
        void EvaluarPosiblesInterrupciones(DateTime fecha); //retornaba IRequerimiento, pero no es valido siempre. Input: IDatosEvaluarPosiblesInterrupciones datosPosiblesInterrupciones

    }
}
