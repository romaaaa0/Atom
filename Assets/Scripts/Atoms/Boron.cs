using System;

namespace Assets
{
    public class Boron : Atom, ISpeedUpAssembly
    {
        public Boron() : base() { }
        protected override string Name { get; } = "Beryllium";
        protected override int Number { get; } = 5;
        protected override string AtomMass { get; } = "Atomic mass: 10.811 u";
        protected override int ContainsElectrons { get; } = 5;
        protected override int ContainsProtons { get; } = 5;
        protected override int ContainsNeutrons { get; } = 6;
        public void SetRequireValues()
        {
            InformationAtom.NumberNeutrons = 5;
            InformationAtom.NumberProtons = 4;
        }
    }
}
