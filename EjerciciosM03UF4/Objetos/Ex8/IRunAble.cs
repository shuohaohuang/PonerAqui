using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Ex8
{
    public interface IRunAble
    {
        public float KmPerHour {  get; set; }
        public virtual void Run()
        {
            Console.WriteLine("Running");
        }
    }
}
