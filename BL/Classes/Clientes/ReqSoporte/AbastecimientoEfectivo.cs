using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class AbastecimientoEfectivo : RequerimientoSoporte
    {

        public AbastecimientoEfectivo(DateTime dtIngreso,IGestorServicios gestorServicios, IPrestadorClientes solicitante, int cantidadEfectivo,
                                        ITipoRequerimiento tipoRequerimiento, EstadoRequerimiento estadoRequerimiento) 
                    : base(dtIngreso, gestorServicios, solicitante, tipoRequerimiento, estadoRequerimiento)
        {
            CantidadEfectivo = cantidadEfectivo;
        }

        public int CantidadBilletes { get; set; }
        public int CantidadEfectivo { get; set; }

        public override List<IEvento> FinalizarRequerimiento(IDatosFinalizarRequerimiento datosFinalizarRequerimiento)
        {
            throw new NotImplementedException();
        }

    }
}
