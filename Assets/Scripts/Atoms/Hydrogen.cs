namespace Assets
{
    public class Hydrogen : Atom
    {
        public Hydrogen() : base() {}
        public override string Name { get; } = "Hydrogen";
        public override string AtomicMass { get; } = "Atomic mass: 1.0078 u";
        public override int ContainsElectrons { get; } = 1;
        public override int ContainsProtons { get; } = 1;
        public override int ContainsNeutrons { get; } = 0;
    }
}
