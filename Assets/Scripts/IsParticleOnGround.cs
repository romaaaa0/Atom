using UnityEngine;

namespace Assets
{
    public static class IsParticleOnGround
    {
        public static void IsSelectParticleOnGround()
        {
            if (InformationAtom.SelectedParticle == null) return;
            if (InformationAtom.SelectedParticle.transform.position.y > -2f)
                InformationAtom.IsParticleOnGround = false;
            else
                InformationAtom.IsParticleOnGround = true;
        }
    }
}
