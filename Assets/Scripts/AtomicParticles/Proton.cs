using UnityEngine;

namespace Assets
{
    public class Proton : AtomicParticle
    {
        protected override void Start()
        {
            base.Start();
            PlacePosition = transform.position;
        }
    }
}
