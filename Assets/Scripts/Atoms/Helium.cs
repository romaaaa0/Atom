namespace Assets
{
    public class Helium : Atom
    {
        public Helium() : base() { }
        protected override string Name { get; } = "Helium";
        protected override int Number { get; } = 2;
        protected override string AtomMass { get; } = "Atomic mass: 4.0026 u";
        protected override int ContainsElectrons { get; } = 2;
        protected override int ContainsProtons { get; } = 2;
        protected override int ContainsNeutrons { get; } = 2;
    }
}
