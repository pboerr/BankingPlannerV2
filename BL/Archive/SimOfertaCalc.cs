using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    /*
    public partial class SimOfertaCalc : IPrestador
    {
        private EstadoOferta _EstadoOferta { get; set; }
        private SimDemandaCalc _PrestacionActual { get; set; }
        //private SimInterrupcionCalculada _InterrupcionActual { get; set; }
        private int _CantidadPrestacionesAcumuladas { get; set; }
        private HashSet<string> _Proficiencies { get; set; } //TODO evaluar hashset por performance para hacer propuestas, y ademas para TiTs
        public HashSet<SimSeccionCalc> ListSimSeccionCalc { get; set; }
        public HashSet<SimTipoCliente> ListSimTiposCliente { get; set; }
        public HashSet<int> ListTiposServicio { get; set; }

        public SimOfertaCalc()
        {
            _EstadoOferta = EstadoOferta.Disponible;
            _CantidadPrestacionesAcumuladas = 0;
            //TODO en la construccion de estas ofertas hay que actualizar su relacion con las secciones a las que aplique
        }
        public Propuesta OfrecerPropuesta(Propuesta propuestaDefinida)
        {
            //TODO incorporar calendario de servicio!
            if(_EstadoOferta != EstadoOferta.Disponible)
            {
                return new Propuesta();
            }
            else
            {               
                if(ListTiposServicio.Contains(propuestaDefinida.SimDemandaCalc.SimDemandaModel.tipo_servicio)
                   && ListSimTiposCliente.Contains(propuestaDefinida.SimDemandaCalc.SimDemandaModel.SimTipoCliente))
                {
                    return new Propuesta(propuestaDefinida.SimDemandaCalc, this, 100, propuestaDefinida.Fecha);
                }
                else
                {
                    return new Propuesta();
                }   
            }
        }
        public void IniciarPrestacionServicio(Propuesta prestacionSeleccionada)
        {
            _EstadoOferta = EstadoOferta.PrestandoServicio;
            _PrestacionActual = prestacionSeleccionada.SimDemandaCalc;         
        }
        public void FinalizarPrestacionServicio()
        {
            _EstadoOferta = EstadoOferta.Disponible;
            _PrestacionActual = null;
            _CantidadPrestacionesAcumuladas++;
        }
        public bool OfertaActiva()
        {
            return (_EstadoOferta != EstadoOferta.Interrumpida) ;
        }
      
    }

    public enum EstadoOferta { Disponible, Interrumpida, PrestandoSoporte, PrestandoServicio }
    */
}
