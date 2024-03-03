using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Ex18
{
    public class HourlyWorker : AWorker
    {
        private int hourSalary;
        private int hours;

        public int HourSalary
        {
            get { return hourSalary; }
            set { hourSalary = value; }
        }

        public int Hours
        {
            get { return hours; }
            set
            {
                if (hours > 60)
                    throw new Exception("can't work more than 60h");
                hours = value;
            }
        }

        public override double ComputePay()
        {
            return this.HourSalary * HourSalary;
        }
    }
}
