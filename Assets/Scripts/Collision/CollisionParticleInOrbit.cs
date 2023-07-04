using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public class CollisionParticleInOrbit : MonoBehaviour, IParticlesInAtom
    {
        [SerializeField] protected int orbitNumber;
        [SerializeField] protected Transform placeOutOfAtom;
        private ChangeNumberParticlesInOrbit _changeNumberParticlesOnOrbit;
        private int _numberElectronsOnOrbit;
        public List<AtomicParticle> Particles { get; set; }
        private void Start()
        {
            _changeNumberParticlesOnOrbit = new ChangeNumberParticlesInOrbit(orbitNumber);
            Particles = new List<AtomicParticle>();
        }
        private void OnTriggerEnter(Collider other)
        {
            _changeNumberParticlesOnOrbit.ChangeNumberParticle(other.gameObject, () => InformationAtom.NumberElectrons++, () => _numberElectronsOnOrbit++);
            _changeNumberParticlesOnOrbit.AddMistakes(other.gameObject, _numberElectronsOnOrbit);
            other.gameObject.transform.parent = transform;
            Particles.Add(other.gameObject.GetComponent<AtomicParticle>());
        }
        private void OnTriggerExit(Collider other)
        {
            _changeNumberParticlesOnOrbit.ChangeNumberParticle(other.gameObject, () => InformationAtom.NumberElectrons--, () => _numberElectronsOnOrbit--);
            _changeNumberParticlesOnOrbit.RemoveMistakes(other.gameObject, _numberElectronsOnOrbit);
            other.gameObject.transform.parent = placeOutOfAtom;
            Particles.Remove(other.gameObject.GetComponent<AtomicParticle>());
        }
    }
}
