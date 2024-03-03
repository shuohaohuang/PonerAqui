using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proveidor
{
    public interface IInteraccion
    {
        public string Notificar()
        {
            return "notificacion";
        }
        public int GenerarCodi()
        {
            return 1;
        }
    }
}
