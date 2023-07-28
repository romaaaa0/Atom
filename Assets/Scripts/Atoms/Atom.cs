using UnityEngine;

namespace Assets
{
    public abstract class Atom : MonoBehaviour
    {
        protected abstract string Name { get; }
        protected abstract int Number { get; }
        protected abstract string AtomMass { get; }
        protected abstract int ContainsElectrons { get; }
        protected abstract int ContainsProtons { get; }
        protected abstract int ContainsNeutrons { get; } 
        public void SetValues()
        {
            InformationAtom.RequiredNumberElectrons = ContainsElectrons;
            InformationAtom.RequiredNumberProtons = ContainsProtons;
            InformationAtom.RequiredNumberNeutrons = ContainsNeutrons;
            InformationAtom.AtomName = Name;
            InformationAtom.AtomMass = AtomMass;
            InformationAtom.AtomNumber = Number;
        }
    }
}
