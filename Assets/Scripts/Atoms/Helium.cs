namespace Assets
{
    public class Helium : Atom
    {
        public Helium() : base() { }
        public override string Name { get; } = "Helium";
        public override string AtomicMass { get; } = "Atomic mass: 4.0026 u";
        public override int ContainsElectrons { get; } = 2;
        public override int ContainsProtons { get; } = 2;
        public override int ContainsNeutrons { get; } = 2;
    }
}
