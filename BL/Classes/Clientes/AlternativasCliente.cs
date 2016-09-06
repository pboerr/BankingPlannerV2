using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class AlternativasCliente
    {
        public IReqServicio Requerimiento { get; set; }
        public IGestorServicios GestorServicios { get; set; }
        public double ValorNeto { get; set; }
        public AlternativasCliente(IReqServicio requerimiento, IGestorServicios gestorServicios)
        {
            Requerimiento = requerimiento;
            GestorServicios = gestorServicios;
            ValorNeto = requerimiento.ValorMinutosCliente / ((gestorServicios.MinutosEstimadosEspera() > 0) ? gestorServicios.MinutosEstimadosEspera() : 1);
        }
    }
}
