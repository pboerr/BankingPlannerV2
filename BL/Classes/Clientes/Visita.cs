using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Visita : IVisita
    {
        #region Properties
        public double CalificacionServicio { get; private set; }
        public ICliente Cliente { get; private set; }
        public DateTime DtLimiteAbandono { get; private set; }
        public DateTime? DtAbandono { get; private set; }
        public DateTime DtIngreso { get; private set; }
        public IGestorServicios GestorServicios { get; private set; }
        public List<IReqServicio> Requerimientos { get; private set; }
        public IReqServicio Requerimiento { get; private set; }
        public ISimulador Simulador { get; private set; }
        public EstadoVisita EstadoVisita { get; private set; }
        #endregion Properties
        #region Constructors
        public Visita(ICliente cliente, DateTime dtIngreso, DateTime dtLimiteAbandono, List<IReqServicio> requerimientos, 
                            ISimulador simulador, IGestorServicios gestorServicios, EstadoVisita estadoVisita)
        {
            Cliente = cliente;
            DtIngreso = dtIngreso;
            DtLimiteAbandono = dtLimiteAbandono;
            Requerimientos = requerimientos;
            Simulador = simulador;
            GestorServicios = gestorServicios;
            EstadoVisita = estadoVisita;
        }
        #endregion Constructors

        #region Functions
        public void Ingresar(DateTime fecha)
        {
            //Cuando ingresa el cliente a la ubicacion, lo primero que hacemos es generar un evento de limite de abandono.
            var eventoLimiteAbandono = new EventoLimiteAbandonoVisita(this, DtLimiteAbandono, Simulador);
            Simulador.FilaEventos.Agregar(eventoLimiteAbandono);

            //Cambiamos el estado de la visita
            EstadoVisita = EstadoVisita.Ingresada;

            //Luego de ingresar a la ubicacion, el cliente evalua la situacion que observa y decide su siguiente requerimiento o abandona.
            var alternativaSeleccionada = SituacionActual();

            //Una vez que evalua la situacion actual, decide: si le resulta aceptable ingresa el requerimiento, y si no abandona.
            if (alternativaSeleccionada.ValorNeto > Cliente.NivelExigencia)
            {
                //ingresa requerimiento
                alternativaSeleccionada.Requerimiento.Ingresar(fecha);
                EstadoVisita = EstadoVisita.RequerimientoEnCurso;
                Requerimiento = alternativaSeleccionada.Requerimiento;
            }
            else
            {
                //abandona la visita
                EstadoVisita = EstadoVisita.Abandonada;
                DtAbandono = fecha;
            }

        }

        AlternativasCliente SituacionActual()
        {
            //Situacion actual (requerimiento con mayor valor para el cliente que cree puede obtener)
            var ubicacion = (Ubicacion)GestorServicios;
            var descendientes = ubicacion.NodoYDescendientes(ubicacion);
            var prestadores = descendientes
                                        .Where(x => x is IPrestadorClientes)
                                        .Cast<IPrestadorClientes>();

            List<AlternativasCliente> alternativas = new List<AlternativasCliente>();
            foreach (var rq in Requerimientos.Where(x => x.EstadoRequerimiento == EstadoRequerimiento.PendienteIngreso))
            {
                var salida = prestadores
                                        .Where(x => x.TiposRequerimientoHabilitados.Contains(rq.TipoRequerimiento))
                                        .Select(y => new AlternativasCliente(rq, y.GestorServicios));
                alternativas.AddRange(salida);
            }

            var alternativaSeleccionada = alternativas
                                                      .OrderBy(a => a.ValorNeto)
                                                      .FirstOrDefault();
            return alternativaSeleccionada;
        }
        void Accionar(DateTime fecha)
        {
            
        }
    
        #endregion Functions
    }
}
