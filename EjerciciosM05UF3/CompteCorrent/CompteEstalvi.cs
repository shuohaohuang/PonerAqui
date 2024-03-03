using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteCorrent
{
    public class CompteEstalvi : ACompte, IInteraccio
    {
        public float TipusInteres { get; set; }

        public CompteEstalvi(
            long numeroCompte,
            string nomTiTular,
            float saldoCompte,
            float tipusInteres
        )
            : base(numeroCompte, nomTiTular, saldoCompte)
        {
            this.TipusInteres = tipusInteres;
        }

        public override void MostrarCompte()
        {
            Console.WriteLine(
                $"Titular:{this.NomTiTular}\n"
                    + $"Numero de compte:{this.NumeroCompte}\n"
                    + $"saldo disponible:{this.SaldoCompte}\n"
                    + $"Balanç:{this.TipusInteres}\n"
            );
        }

        public bool Extreure(float quantitat)
        {
            return quantitat <= this.SaldoCompte;
        }
    }
}
