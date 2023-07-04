using System.Collections.Generic;

namespace Assets
{
    public interface IFreeze
    {
        void Freeze(List<AtomicParticle> particles);
    }
}
