using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public enum EstadoRequerimiento { PendienteIngreso, Ingresado, Iniciado, Finalizado, Abandonado }
    public enum EstadoVisita { PendienteIngreso, Ingresada, RequerimientoEnCurso, EnEspera, Finalizada, Abandonada}
    public enum EstadoPrestador { Disponible, Interrumpido, PrestandoServicio, PrestandoSoporte, EnMovimiento }
    public enum EstadoPropuesta { Pendiente, EnServicio, Interrumpida, Finalizada }
    public enum EstadoNodo { Disponible, Interrumpido }


    //public enum TipoRequerimiento { ExtraccionEfectivo, DepositoEfectivo, DepositoCheques, DepositoSobres, OtrasOperaciones, Soporte1L, Soporte2L, Abastecimiento, SoporteTesoro }
    //public enum TipoInterrupcion { DisponibilidadEfectivo, CapacidadDepositoEfectivo, CapacidadDepositoCheques, CapacidadDepositoSobres, FallaDispensador }
    //public enum TipoCliente { EmpresaGrande, EmpresaMediana, EmpresaChica, RentaAlta, RentaMedia, RentaBaja, NoCliente }
    //public enum TipoEvento
    //{
    //    IngresoRequerimiento, InicioRequerimiento, FinRequerimiento, LimiteAbandono,
    //    InicioMovimiento, FinMovimiento, Nulo, PropuestaRequerida
    //}

}
