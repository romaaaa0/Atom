using UnityEngine;

namespace Assets
{
    public interface IParticleCreator
    {
        void Create(GameObject atomicParticle, KeyCode keyCode);
    }
}
