using Ejercicios;

namespace Ejercicios.Ex2
{
    public class Visit
    {
        const string Format =
            "|   Propietari   |   Pacient   |   Motiu   |      Date      |\n" + "|{0}|{1}|{2}|{3}|";
        public Owner? Owner { get; set; }
        public Pacient? Pacient { get; set; }
        public string? ReasonVisit { get; set; }

        public DateTime DateTime { get; set; }

        public Visit(Owner owner, Pacient pacient, string reason)
        {
            this.Owner = owner;
            this.Pacient = pacient;
            this.ReasonVisit = reason;
            this.DateTime = DateTime.Now;
        }

        public override string ToString()
        {
            return string.Format(
                Format,
                Txt.Format(Owner.Name, 16),
                Txt.Format(Pacient.Name, 13),
                Txt.Format(ReasonVisit, 11),
                Txt.Format(DateTime.ToString(),16)
            );
        }
    }
}
