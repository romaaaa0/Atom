namespace Assets
{
    public class Beryllium : Atom, ISpeedUpAssembly
    {
        public Beryllium() : base() { }
        protected override string Name { get; } = "Beryllium";
        protected override int Number { get; } = 4;
        protected override string AtomMass { get; } = "Atomic mass: 9.0122 u";
        protected override int ContainsElectrons { get; } = 4;
        protected override int ContainsProtons { get; } = 4;
        protected override int ContainsNeutrons { get; } = 5;
        public void SetRequireValues()
        {
            InformationAtom.NumberNeutrons = 4;
            InformationAtom.NumberProtons = 3;
        }
    }
}
