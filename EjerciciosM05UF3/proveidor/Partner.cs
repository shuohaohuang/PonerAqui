using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proveidor
{
    public class Partner : Person, IInteraccion
    {
        public int CodiPartner { get; set; }
        public int indexRetability { get; set; }
        public Partner(int CodiPartner, int codi, int indexRetability, string name, string surname)
        {
            this.CodiPartner = CodiPartner;
            this.indexRetability = indexRetability;
            this.FirstName = name;
            this.SurName = surname;
            this.Codi = codi;
        }

        public override string Salute()
        {
            return this.FirstName + " " + this.SurName + " te saluda";
        }

        public string mostrarRisc()
        {
            return "risc";
        }
    }
}
