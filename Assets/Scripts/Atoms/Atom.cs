using UnityEngine;

namespace Assets
{
    public abstract class Atom
    {
        public abstract string Name { get; }
        public abstract string AtomicMass { get; }
        public abstract int ContainsElectrons { get; }
        public abstract int ContainsProtons { get; }
        public abstract int ContainsNeutrons { get; } 
        public Atom()
        {
            InformationAtom.RequiredNumberElectrons = ContainsElectrons;
            InformationAtom.RequiredNumberProtons = ContainsProtons;
            InformationAtom.RequiredNumberNeutrons = ContainsNeutrons;
            UI.Instance.FillParameters(Name, AtomicMass);
        }
    }
}
