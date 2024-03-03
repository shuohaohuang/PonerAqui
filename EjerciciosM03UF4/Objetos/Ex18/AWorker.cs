using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Ex18
{
    public abstract class AWorker
    {
        public string? Names { get; set; }
        public decimal Fee { get; set; }

        public abstract double ComputePay();
    }
}
