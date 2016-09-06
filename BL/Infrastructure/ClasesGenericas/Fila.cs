using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Fila<T> : Queue<T>, IFila<T>
    {
        public void AgregarElementos(List<T> elementos)
        {
            foreach (var e in elementos)
            {
                Enqueue(e);
            }
        }
    }
}
