using System;
using UnityEngine;

namespace Assets
{
    public class ChangeNumberParticlesInOrbit 
    {
        private int _numberPlacesAvaible;
        private int _maxPlacesOnOrbit;
        private int _orbitNumber;
        public ChangeNumberParticlesInOrbit(int orbitNumber)
        {
            _orbitNumber = orbitNumber;
            _maxPlacesOnOrbit = _orbitNumber * _orbitNumber * 2;
            CheckPlacesAvaible();
        }
        private void CheckPlacesAvaible()
        {
            if(_orbitNumber == 1)
            {
                _numberPlacesAvaible = 2;
                return;
            }
            var lastOrbitMaxPlacesAvaible = (_orbitNumber - 1) * (_orbitNumber - 1) * 2;
            var difference = InformationAtom.RequiredNumberElectrons - lastOrbitMaxPlacesAvaible;
            if(difference < 0)
            {
                _numberPlacesAvaible = 0;
                return;
            }
            if (difference < _maxPlacesOnOrbit)
                _numberPlacesAvaible = difference;
            else
                _numberPlacesAvaible = _maxPlacesOnOrbit;
        }
        public void AddMistakes(GameObject objectCollision, int numberElectrons)
        {
            if (objectCollision.GetComponent<Electron>() && numberElectrons > _numberPlacesAvaible)
                InformationAtom.NumberMistakes++;
            else if(objectCollision.GetComponent<Proton>() || objectCollision.GetComponent<Neutron>())
                InformationAtom.NumberMistakes++;
        }
        public void RemoveMistakes(GameObject objectCollision, int numberElectrons)
        {
            if (objectCollision.GetComponent<Electron>() && numberElectrons >= _numberPlacesAvaible)
                InformationAtom.NumberMistakes--;
            else if (objectCollision.GetComponent<Proton>() || objectCollision.GetComponent<Neutron>())
                InformationAtom.NumberMistakes--;
        }
        public void ChangeNumberParticle(GameObject objectCollision, Action changeNumberElectrons, Action changeNumberElectronsOnOrbit)
        {
            if (objectCollision.GetComponent<Electron>())
            {
                changeNumberElectronsOnOrbit.Invoke();
                changeNumberElectrons.Invoke();
            }
        }
    }
}
