using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    //public class InterrupcionBanca : IInterrupcion
    //{
    //    public DateTime DtInicio { get; private set; }
    //    public DateTime DtFin { get; private set; }        
    //    public ITipoInterrupcion TipoInterrupcion { get; private set; }
    //    public ITipoRequerimiento TipoRequerimientoSoporte { get; private set; }
    //    public IInterrumpible Interrumpido { get; private set; }

    //    //Constructor para interrupciones que dependen de otros eventos para fin
    //    public InterrupcionBanca(DateTime dtInicio, ITipoInterrupcion tipoInterrupcion, ITipoRequerimiento tipoRequerimientoSoporte, IInterrumpible interrumpido)
    //    {
    //        Interrumpido = interrumpido;
    //        DtInicio = dtInicio;
    //        TipoInterrupcion = tipoInterrupcion;
    //        TipoRequerimientoSoporte = tipoRequerimientoSoporte;
    //    }
    //    //Constructor para interrupciones con sorteo de fin
    //    //public InterrupcionBanca(DateTime dtInicio, DateTime dtFin, ITipoInterrupcion tipoInterrupcion)
    //    //{
    //    //    DtInicio = dtInicio;
    //    //    DtFin = dtFin;
    //    //    TipoInterrupcion = tipoInterrupcion;
    //    //}
    //    public IRequerimiento IniciarInterrupcion()
    //    {
    //        return null;   
    //    }
    //    public void FinalizarInterrupcion(DateTime fecha)
    //    {
    //        DtFin = fecha;
    //    }


    //}
}
