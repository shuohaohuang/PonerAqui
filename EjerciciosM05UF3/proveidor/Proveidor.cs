using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proveidor
{
    public class Proveidor : Person, IInteraccion
    {
        public int CodiProveidor { get; set; }
        public int terminiPagament { get; set; }
        public Proveidor(int codiClient, int codi, int terminiPagament, string name, string surname)
        {
            this.CodiProveidor = codiClient;
            this.terminiPagament = terminiPagament;
            this.FirstName = name;
            this.SurName = surname;
            this.Codi = codi;
        }

        public override string Salute()
        {
            return this.FirstName + " " + this.SurName + " te saluda";
        }

        public string retornarMage(int terminiPagament)
        {
            return $"Falten {terminiPagament} dies";
        }
    }
}
