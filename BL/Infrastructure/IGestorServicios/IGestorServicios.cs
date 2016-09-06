using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IGestorServicios
    {
        Fila<IRequerimiento> FilaEsperaRequerimientos { get; }
        List<IRequerimiento> RequerimientosFinalizados { get; }
        void IngresarRequerimiento(IRequerimiento requerimiento);
        void ProcesarLimiteAbandono(IDatosProcesarLimiteAbandono datosLimiteAbandono);
        void IniciarRequerimiento(IRequerimiento requerimiento);
        void FinalizarRequerimiento(IDatosFinalizarRequerimiento datosFinalizarRequerimiento);
        double MinutosEstimadosEspera();
    }

    

}
