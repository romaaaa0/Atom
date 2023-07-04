using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public class FreezeCore : MonoBehaviour, IFreeze
    {
        [SerializeField] private GameObject basicProton;
        public void Freeze(List<AtomicParticle> particles)
        {
            foreach (var particle in particles) particle.gameObject.GetComponent<SphereCollider>().enabled = false;
            basicProton.GetComponent<SphereCollider>().enabled = false;
            GetComponent<SphereCollider>().enabled = false;
            GetComponent<Animator>().Play("FreezeCore");
        }
    }
}
