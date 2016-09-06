using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class DepositoCheques : RequerimientoBanca
    {
        public int CantidadCheques { get; set; }
        public DepositoCheques(int cantidadCheques, IGestorServicios gestorServicios, ITipoRequerimiento tipoRequerimiento,
                                    DateTime dtIngreso, EstadoRequerimiento estadoRequerimiento, ITipoCliente tipoCliente)
            : base(gestorServicios, tipoCliente, tipoRequerimiento, dtIngreso, estadoRequerimiento)
        {
            CantidadCheques = cantidadCheques;
        }

        public override List<IEvento> FinalizarRequerimiento(IDatosFinalizarRequerimiento datosFinalizarRequerimiento)
        {
            throw new NotImplementedException();
        }
    }
}
