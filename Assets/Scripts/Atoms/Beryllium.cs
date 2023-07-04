namespace Assets
{
    public class Beryllium : Atom
    {
        public Beryllium() : base() { }
        public override string Name { get; } = "Beryllium";
        public override string AtomicMass { get; } = "Atomic mass: 9.0122 u";
        public override int ContainsElectrons { get; } = 4;
        public override int ContainsProtons { get; } = 4;
        public override int ContainsNeutrons { get; } = 5;
    }
}
