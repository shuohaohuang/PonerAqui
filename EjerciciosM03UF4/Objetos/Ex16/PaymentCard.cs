using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Ex16
{
    public class PaymentCard
    {
        public double Balance { get; set; }

        public PaymentCard(double openingBalance)
        {
            // write code here
            this.Balance = openingBalance;
        }

        public override string ToString()
        {
            // write code here
            return $"The card has a balance of {Balance} euros";
        }
    }
}
