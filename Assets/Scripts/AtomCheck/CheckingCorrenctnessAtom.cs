using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public class CheckingCorrenctnessAtom : IChecking
    {
        private UI _ui;
        private List<GameObject> orbits  = new List<GameObject>();
        private GameObject _core;
        private bool _canFuctionWorkCore = true;
        private bool _canFuctionWorkOrbit1 = true;
        private bool _canFuctionWorkOrbit2 = true;
        public CheckingCorrenctnessAtom(List<GameObject> orbits, GameObject core)
        {
            _ui = UI.Instance;
            this.orbits = orbits;
            _core = core;
        }
        public void Check()
        {
            LevelPassed();
            HideOrbit();
            HideCore();
        }
        private void LevelPassed()
        {
            if (InformationAtom.NumberMistakes > 0) return;
            if (InformationAtom.NumberProtons == InformationAtom.RequiredNumberProtons
                && InformationAtom.NumberNeutrons == InformationAtom.RequiredNumberNeutrons
                && InformationAtom.NumberElectrons == InformationAtom.RequiredNumberElectrons)
            {
                _ui.CompleteAtom();
                InformationAtom.IsAtomAssembled = true;
                PlayerPrefs.SetInt(InformationAtom.AtomName, 1);
            }
        }
        private void HideCore()
        {
            if (InformationAtom.NumberMistakes > 0) return;
            if (InformationAtom.NumberProtons == InformationAtom.RequiredNumberProtons && InformationAtom.NumberNeutrons == InformationAtom.RequiredNumberNeutrons && _canFuctionWorkCore == true)
            {
                _core.GetComponent<IFreeze>().Freeze(_core.GetComponent<IParticlesInAtom>().Particles);
                AddOrbit(0);
                _canFuctionWorkCore = false;
                InformationAtom.HowManyOrbitsAdded = 1;
            }
        }
        private void HideOrbit()
        {
            if (InformationAtom.NumberElectrons == InformationAtom.RequiredNumberElectrons || InformationAtom.NumberMistakes > 0) return;
            if (InformationAtom.NumberElectrons == 2 && _canFuctionWorkOrbit1 == true)
            {
                orbits[0].GetComponent<IFreeze>().Freeze(orbits[0].GetComponent<IParticlesInAtom>().Particles);
                AddOrbit(1);
                _canFuctionWorkOrbit1 = false;
                InformationAtom.HowManyOrbitsAdded = 2;
            }
            if (InformationAtom.NumberElectrons == 8 && _canFuctionWorkOrbit2 == true)
            {
                orbits[1].GetComponent<IFreeze>().Freeze(orbits[1].GetComponent<IParticlesInAtom>().Particles);
                AddOrbit(2);
                _canFuctionWorkOrbit2 = false;
                InformationAtom.HowManyOrbitsAdded = 3;
            }
        }
        private void AddOrbit(int orbitNumber)
        {
            orbits[orbitNumber].gameObject.GetComponent<IApear>().Apear(orbits[orbitNumber]);
        }
    }
}
