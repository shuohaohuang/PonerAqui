using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteCorrent
{
    public interface IInteraccio
    {
        public virtual bool Depositar(float quantitat)
        {
            return quantitat > 0;
        }
        public abstract bool Extreure(float quantitat);

    }
}
