using System;
using UnityEngine;

namespace Assets
{
    public class ParticleAttraction : IAttraction
    {
        public void Attraction(Transform particle, Vector3 placePosition, float speed)
        {
            var particlePosition = particle.position;
            particle.position = Vector3.MoveTowards(particlePosition, placePosition, speed * Time.deltaTime);
        }
    }
}
