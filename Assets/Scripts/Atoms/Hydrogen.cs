namespace Assets
{
    public class Hydrogen : Atom
    {
        public Hydrogen() : base() {}
        protected override string Name { get; } = "Hydrogen";
        protected override int Number { get; } = 1;
        protected override string AtomMass { get; } = "Atomic mass: 1.0078 u";
        protected override int ContainsElectrons { get; } = 1;
        protected override int ContainsProtons { get; } = 1;
        protected override int ContainsNeutrons { get; } = 0;
    }
}
