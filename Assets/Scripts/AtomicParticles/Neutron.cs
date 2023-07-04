using UnityEngine;

namespace Assets
{
    public class Neutron : AtomicParticle
    {
        protected override void Start()
        {
            base.Start();
            PlacePosition = transform.position;
        }
    }
}

