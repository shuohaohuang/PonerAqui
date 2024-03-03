namespace Proveidor
{
    public abstract class Person
    {
        public string? SurName { get; set; }
        public string? FirstName { get; set; }
        public int Codi { get; set; }
        public abstract string Salute();
    }
}
