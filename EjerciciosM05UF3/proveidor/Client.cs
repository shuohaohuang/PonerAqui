using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proveidor
{
    public class Client : Person, IInteraccion
    {
        public int CodiClient { get; set; }
        public string? TipusClient { get; set; }
        public Client(int codiClient, int codi, string? tipusClient, string name, string surname)
        {
            this.CodiClient = codiClient;
            this.TipusClient = tipusClient;
            this.FirstName = name;
            this.SurName = surname;
            this.Codi = codi;
        }

        public override string Salute()
        {
            return this.FirstName + " " + this.SurName + " te saluda";
        }
        
        public double calcularDescompte()
        {
            return 2d;
        }
    }

}
