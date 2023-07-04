using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public class CollisionParticleInCore : MonoBehaviour, IParticlesInAtom
    {
        [SerializeField] private Transform placeOutOfAtom;
        private ChangeNumberParticlesInCore _changeNumberOnCore;
        public List<AtomicParticle> Particles { get; set; }
        private void Start()
        {
            _changeNumberOnCore = new ChangeNumberParticlesInCore();
            Particles = new List<AtomicParticle>();
        }
        private void OnTriggerEnter(Collider other)
        {
            _changeNumberOnCore.ChangeNumberParticle(other.gameObject, () => InformationAtom.NumberProtons++, () => InformationAtom.NumberNeutrons++);
            _changeNumberOnCore.AddMistakes(other.gameObject);
            other.gameObject.transform.parent = transform;
            Particles.Add(other.gameObject.GetComponent<AtomicParticle>());
        }
        private void OnTriggerExit(Collider other)
        {
            _changeNumberOnCore.ChangeNumberParticle(other.gameObject, () => InformationAtom.NumberProtons--, () => InformationAtom.NumberNeutrons--);
            _changeNumberOnCore.RemoveMistakes(other.gameObject);
            other.gameObject.transform.parent = placeOutOfAtom;
            Particles.Remove(other.gameObject.GetComponent<AtomicParticle>());
        }
    }
}
