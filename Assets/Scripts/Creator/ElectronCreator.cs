using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public class ElectronCreator : ParticleCreator<Electron>
    {
        public ElectronCreator(Electron electron, Transform electronGenerationRing, Transform folderLocation) : base(electron, electronGenerationRing, folderLocation)
        { 
        }
    }
}
