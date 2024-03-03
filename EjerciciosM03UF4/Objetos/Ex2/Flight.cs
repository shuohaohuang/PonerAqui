using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Ex2
{
    public class Flight
    {
        private string company;
        private float time;
        private string origin;
        private string destination;

        public Flight(string company, float time, string origin, string destination)
        {
            this.Company = company;
            this.Time = time;
            this.Origin = origin;
            this.Destination = destination;
        }

        public string Company
        {
            get { return company; }
            set { Company = value; }
        }
        public float Time
        {
            get { return time; }
            set { time = value; }
        }
        public string Origin
        {
            get { return origin; }
            set { origin = value; }
        }
        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }
    }
}
