using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IVisita
    {
        ISimulador Simulador { get; }
        IGestorServicios GestorServicios { get; }
        ICliente Cliente { get; }
        EstadoVisita EstadoVisita { get; }
        List<IReqServicio> Requerimientos { get; }
        IReqServicio Requerimiento { get; }
        DateTime DtIngreso { get; }
        DateTime? DtAbandono { get; } //Fecha de abandono real
        DateTime DtLimiteAbandono { get; } //Fecha limite abandono en construccion
        double CalificacionServicio { get; }

        void Ingresar(DateTime fecha);


        //void Accionar(DateTime fecha);

        /*
        // El inicio del requerimiento implica un cambio de estado simple.
        void IniciarRequerimiento();

        // Cuando finaliza el requerimiento actual, el cliente evalua si ingresa uno
        // adicional, si abandona los que tiene o si se retira con sus requerimientos
        // completos.
        // CalificarServicio: en funcion del nivel de servicio recibido y el nivel de exigencia
        // del cliente.
        void FinalizarRequerimiento();
        // El cliente evalua cual de los requerimientos de su fila va a
        // ingresar en primer lugar, y en que gestor de servicios.
        // Para esto, va a consultar el tiempo estimado de atencion de cada requerimiento
        // a cada IGS descendiente del IGS actual, y decidira comenzar por el primero.
        void Ingresar();

        //El retiro implica el fin de un lote de requerimientos determinado.
        void Retirar();
        void EvaluarAbandono();
        */
    }
}
