using System;

namespace Assets
{
    public class Boron : Atom
    {
        public Boron() : base() { }
        public override string Name { get; } = "Beryllium";
        public override string AtomicMass { get; } = "Atomic mass: 10.811 u";
        public override int ContainsElectrons { get; } = 5;
        public override int ContainsProtons { get; } = 5;
        public override int ContainsNeutrons { get; } = 6;
    }
}
