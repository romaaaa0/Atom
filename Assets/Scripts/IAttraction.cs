using UnityEngine;

namespace Assets
{
    public interface IAttraction
    {
        void Attraction(Transform particle, Vector3 placePosition, float speed);
    }
}
