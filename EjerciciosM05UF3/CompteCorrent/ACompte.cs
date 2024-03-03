namespace CompteCorrent
{
    public abstract class ACompte
    {
        public long NumeroCompte {  get; set; }
        public string NomTiTular { get; set;}
        public float SaldoCompte { get; set; }

        protected ACompte(long numeroCompte, string nomTiTular, float saldoCompte)
        {
            this.NumeroCompte = numeroCompte;
            this.NomTiTular = nomTiTular;
            this.SaldoCompte = saldoCompte;
        }

        public abstract void MostrarCompte();
    }
}
