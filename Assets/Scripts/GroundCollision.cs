using UnityEngine;

namespace Assets
{
    public class GroundCollision : MonoBehaviour
    {
        private void Update()
        {
            if (InformationAtom.SelectedParticle == null) return;
            if (InformationAtom.SelectedParticle.transform.position.y > -2f)
                InformationAtom.IsParticleOnGround = false;
            else
                InformationAtom.IsParticleOnGround = true;
        }
    }
}
