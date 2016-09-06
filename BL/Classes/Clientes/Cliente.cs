using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Cliente : ICliente
    {
        public int NivelExigencia { get; private set; }
        public string Nombre { get; private set; }
        public int Prioridad { get; private set; }
        public int Sla { get; private set; }
        public double Valor { get; private set; }
        public ITipoCliente TipoCliente { get; private set; }
        public ISimulador Simulador { get; private set; }
        public List<IVisita> Visitas { get; private set; }

        public Cliente(ISimulador simulador, List<IVisita> visitas, ITipoCliente tipoCliente, int nivelExigencia, string nombre, int prioridad, int sla, double valor)
        {
            Simulador = simulador;
            Visitas = visitas;
            TipoCliente = tipoCliente;
            NivelExigencia = nivelExigencia;
            Nombre = nombre;
            Prioridad = prioridad;
            Sla = sla;
            Valor = valor;
        }
    }
}
