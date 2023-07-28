using System;

namespace Assets
{
    public class Lithium : Atom
    {
        public Lithium() : base() { }
        protected override string Name { get; } = "Lithium";
        protected override int Number { get; } = 3;
        protected override string AtomMass { get; } = "Atomic mass: 6.9410 u";
        protected override int ContainsElectrons { get; } = 3;
        protected override int ContainsProtons { get; } = 3;
        protected override int ContainsNeutrons { get; } = 4;
    }
}
