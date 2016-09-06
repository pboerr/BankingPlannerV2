using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class FilaEventos : LinkedList<IEvento>, IFilaEventos
    {
        public bool Activa
        {
            get
            {
                return this.Count() > 0 ? true : false;
            }
        }
        public IEvento ProximoEvento()
        {
            return this.First();
        }
        public List<IEvento> EventosProcesados { get; private set; }
        public FilaEventos()
        {
            EventosProcesados = new List<IEvento>();
        }
        public void Agregar(IEvento nuevoEvento)
        {
            //TODO revisar esta linea
            var prevItem = Find(this.Where(x => x.Fecha < nuevoEvento.Fecha).OrderByDescending(x => x.Fecha).FirstOrDefault());
            if (prevItem == null)
            {
                AddFirst(nuevoEvento);
            }
            else
            {
                AddAfter(prevItem, nuevoEvento);
            }

        }
        public void AgregarLista(IEnumerable<IEvento> listaEventos)
        {
            var listaOrdenada = listaEventos.OrderBy(x => x.Fecha).ToList();
            foreach (var e in listaOrdenada)
            {
                Agregar(e);
            }
        }
        public void Archivar(IEvento eventoArchivar)
        {
            EventosProcesados.Add(eventoArchivar);
            Remove(eventoArchivar);
        }
        public void BorrarLista()
        {
            Clear();
        }

    }
}
