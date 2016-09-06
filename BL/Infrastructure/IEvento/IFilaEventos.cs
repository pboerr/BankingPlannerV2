using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IFilaEventos
    {
        bool Activa { get; }
        IEvento ProximoEvento();
        List<IEvento> EventosProcesados { get; }
        void Agregar(IEvento nuevoEvento);
        void Archivar(IEvento eventoArchivar);
        void AgregarLista(IEnumerable<IEvento> nuevosEventos);
        void BorrarLista();
    }



}
