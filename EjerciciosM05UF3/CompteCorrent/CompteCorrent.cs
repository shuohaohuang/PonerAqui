using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteCorrent
{
    public class CompteCorrent : ACompte, IInteraccio
    {
        public float Balance { get; set; }

        public CompteCorrent(long numeroCompte, string nomTiTular, float saldoCompte, float balance)
            : base(numeroCompte, nomTiTular, saldoCompte)
        {
            this.Balance = balance;
        }

        public override void MostrarCompte()
        {
            Console.WriteLine(
                $"Titular:{this.NomTiTular}\n"
                    + $"Numero de compte:{this.NumeroCompte}\n"
                    + $"saldo disponible:{this.SaldoCompte}\n"
                    + $"Balanç:{this.Balance}\n"
            );
        }

        public bool PucExtreure(float quantitat)
        {
            return quantitat <= this.Balance;
        }

        public bool Extreure(float quantitat)
        {
            return PucExtreure(quantitat);
        }
    }
}
