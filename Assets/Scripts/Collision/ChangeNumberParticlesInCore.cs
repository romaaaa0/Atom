using System;
using UnityEngine;

namespace Assets
{
    public class ChangeNumberParticlesInCore 
    {
        public void RemoveMistakes(GameObject objectCollision)
        {
            if (objectCollision.GetComponent<Electron>())
            {
                InformationAtom.NumberMistakes--;
            }
            else if (objectCollision.GetComponent<Proton>() && InformationAtom.NumberProtons >= InformationAtom.RequiredNumberProtons)
            {
                InformationAtom.NumberMistakes--;
            }
            else if (objectCollision.GetComponent<Neutron>() && InformationAtom.NumberNeutrons >= InformationAtom.RequiredNumberNeutrons)
            {
                InformationAtom.NumberMistakes--;
            }
        }
        public void AddMistakes(GameObject objectCollision)
        {
            if (objectCollision.GetComponent<Electron>())
            {
                InformationAtom.NumberMistakes++;
            }
            else if (objectCollision.GetComponent<Proton>() && InformationAtom.NumberProtons > InformationAtom.RequiredNumberProtons)
            {
                InformationAtom.NumberMistakes++;
            }
            else if (objectCollision.GetComponent<Neutron>() && InformationAtom.NumberNeutrons > InformationAtom.RequiredNumberNeutrons)
            {
                InformationAtom.NumberMistakes++;
            }
        }
        public void ChangeNumberParticle(GameObject objectCollision, Action changeNumberProtons, Action changeNumberNeutrons)
        {
            if (objectCollision.GetComponent<Proton>())
                changeNumberProtons.Invoke();
            if (objectCollision.GetComponent<Neutron>())
                changeNumberNeutrons.Invoke();
        }
    }
}