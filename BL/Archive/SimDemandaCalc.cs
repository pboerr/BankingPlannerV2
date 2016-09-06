using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    /*
    public class SimDemandaCalc //: IPrestacion
    {
        public int SimDemandaId { get; set; }
        public DateTime DtIngreso { get; set; }
        public DateTime? DtAtencion { get; set; }
        public DateTime DtEgreso { get; set; }
        public int ProfundidadFila { get; set; }
        public int PrestadoresActivos { get; set; }
        public DateTime DtLimiteAbandono { get; set; }
        public SimDemanda SimDemandaModel { get; set; }
        public SimOfertaCalc SimOfertaCalc { get; set; }
        public SimSeccionCalc SimSeccionCalc { get; set; }
        public double Costo { get; set; }

        public SimDemandaCalc(int simDemandaId, SimDemanda simDemanda, DateTime dtLlegada)
        {
            SimDemandaId = simDemandaId;

            DtIngreso = dtLlegada;

            SimDemandaModel = simDemanda;
        }

        public void IngresarPrestacion(IEvento eventoIngresar)
        {

            //Actualizamos la fecha de ingreso en la SimDemandaCalc
            DtIngreso = eventoIngresar.Fecha;
            //Sorteamos la fecha de abandono
            DtLimiteAbandono = eventoIngresar.Fecha.AddMinutes(30); //TODO sortear tiempo maximo de espera
            //Generamos evento limiteAbandono y lo agregamos a la fila del simulador
            var eventoAbandono = new EventoLimiteAbandono(DtLimiteAbandono, this, TipoEvento.LimiteAbandono);
            if (eventoAbandono != null)
            {
                SimSeccionCalc.SimSiteCalc.IngresarEvento(eventoAbandono);
            }
        }
        public void IniciarConsumo(Propuesta propuestaSeleccionada, int profundidadFila, int ofertasActivas)
        {
            ProfundidadFila = profundidadFila;
            PrestadoresActivos = ofertasActivas;
            SimOfertaCalc = propuestaSeleccionada.SimOfertaCalc;
            Costo = propuestaSeleccionada.Costo;
            DtAtencion = propuestaSeleccionada.Fecha;
            SimOfertaCalc.IniciarPrestacionServicio(propuestaSeleccionada);

        }

        public void FinalizarConsumo(EventoFinServicio eventoFinalizar)
        {            
            DtEgreso = eventoFinalizar.Fecha;
            SimOfertaCalc.FinalizarPrestacionServicio();
        }

        public void AbandonarConsumo(IEvento eventoAbandonar)
        {
            //Si aplica abandonar, llamamos al metodo correspondiente en la seccion -> archivamos evento de limiteAbandono.
            //if (eventoLimiteAbandono.Fecha <= eventoLimiteAbandono.SimDemandaCalculada.DtLimiteAbandono)
            //{
            //    eventoLimiteAbandono.SimDemandaCalculada.SimDemanda.SimSeccion.AbandonarDemanda(eventoLimiteAbandono);
            //}
        }



        //public void IniciarConsumoServicio(IEvento eventoIniciar)
        //{
        //    DtAtencion = eventoIniciar.Fecha;
        //    DtEgreso = eventoIniciar.Fecha.AddMinutes(30); //TODO agregar sorteo de duracion
        //    Prestador = (eventoIniciar.ObjetoInvolucrado;
        //    SimOfertaId = eventoIniciar.SimOferta.id;
        //}

        //public void FinalizarConsumo(IEvento eventoEgreso)
        //{
        //    DtEgreso = eventoEgreso.Fecha;
        //}

        //public void AbandonarConsumoServicio(Evento eventoLimiteAbandono)
        //{
        //    DtLimiteAbandono = eventoLimiteAbandono.Fecha;
        //}
    }
    */
}
