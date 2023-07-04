using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public class FreezeOrbit : MonoBehaviour, IFreeze
    {
        public void Freeze(List<AtomicParticle> particles)
        {
            foreach (var particle in particles) particle.gameObject.GetComponent<SphereCollider>().enabled = false;
            GetComponent<MeshCollider>().enabled = false;
            GetComponent<Animator>().Play("FreezeOrbit");
        }
    }
}
