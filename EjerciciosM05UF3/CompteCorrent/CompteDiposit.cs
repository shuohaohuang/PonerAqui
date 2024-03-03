using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteCorrent
{
    public class CompteDiposit : ACompte, IInteraccio
    {
        private const int Risc= 6;
        public int SemaforRisc { get; }

        public CompteDiposit(
            long numeroCompte,
            string nomTiTular,
            float saldoCompte
        )
            : base(numeroCompte, nomTiTular, saldoCompte)
        {
            this.SemaforRisc = Risc;
        }

        public override void MostrarCompte()
        {
            Console.WriteLine(
                $"Titular:{this.NomTiTular}\n"
                    + $"Numero de compte:{this.NumeroCompte}\n"
                    + $"Saldo disponible:{this.SaldoCompte}\n"
                    + $"Semafor risc:{this.SemaforRisc}\n"
            );
        }

        public bool Extreure(float quantitat)
        {
            return quantitat <= this.SaldoCompte;
        }
        public void MostrarRisc(int risc)
        {
            Console.WriteLine("Risc de {0}%", risc * this.SemaforRisc / 100); ;
        }
    }
}
