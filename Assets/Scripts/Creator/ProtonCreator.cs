using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public class ProtonCreator : ParticleCreator<Proton>
    {
        public ProtonCreator(Proton proton, Transform protonGenerationRing, Transform folderLocation) : base(proton, protonGenerationRing, folderLocation)
        {
        }
    }
}
