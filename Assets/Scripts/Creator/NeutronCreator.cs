using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public class NeutronCreator : ParticleCreator<Neutron>
    {
        public NeutronCreator(Neutron neutron, Transform neutronGenerationRing, Transform folderLocation) : base(neutron, neutronGenerationRing, folderLocation)
        {
        }
    }
}
