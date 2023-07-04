using System;

namespace Assets
{
    public class Lithium : Atom
    {
        public Lithium() : base() { }
        public override string Name { get; } = "Lithium";
        public override string AtomicMass { get; } = "Atomic mass: 6.9410 u";
        public override int ContainsElectrons { get; } = 3;
        public override int ContainsProtons { get; } = 3;
        public override int ContainsNeutrons { get; } = 4;
    }
}
