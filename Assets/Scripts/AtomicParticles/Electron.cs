using UnityEngine;

namespace Assets
{
    public class Electron : AtomicParticle
    {
        protected override void Start()
        {
            base.Start();
            PlacePosition = transform.position;
        }
    }
}

