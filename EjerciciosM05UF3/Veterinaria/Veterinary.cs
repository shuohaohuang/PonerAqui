using Veterinary;

namespace Veterinaria
{
    public class Visit
    {
        const string Format = 
            "|Propietari\t\t|Pacient\t\t|Motiu\t\t|\n" +
            "{0}\t\t\t|{1}\t\t\t|{2}\t\t\t|";
        public Owner? Owner { get; set; }
        public Pacient? Pacient { get; set; }
        public string? ReasonVisit {  get; set; }

        public Visit(Owner owner, Pacient pacient, string reason)
        {
            this.Owner = owner;
            this.Pacient = pacient;
            this.ReasonVisit = reason;
        }

        public override string ToString()
        {
            return string.Format(Format, Owner.Name, Pacient.Name, this.ReasonVisit);
        }


    }
}
