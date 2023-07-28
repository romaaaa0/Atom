using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public class ParticleCreator<T> : ICreator where T : AtomicParticle
    {
        protected Transform particleGenerationRing;
        protected Transform folderLocation;
        protected T particle;
        private float _offSet = 1f;
        public ParticleCreator(T particle, Transform particleGenerationRing, Transform folderLocation)
        {
            this.particle = particle;
            this.particleGenerationRing = particleGenerationRing;
            this.folderLocation = folderLocation;
        }
        public void CreateParticle()
        {
            var isPlaceAvaible = new Dictionary<Vector3, bool>();
            var spawnPointRight = particleGenerationRing.position.x + (particleGenerationRing.localScale.x / 2) - _offSet;
            var spawnPointLeft = particleGenerationRing.position.x - (particleGenerationRing.localScale.x / 2) + _offSet;
            var spawnPointTop = particleGenerationRing.position.z + (particleGenerationRing.localScale.z / 2) + _offSet;
            var spawnPointBottom = particleGenerationRing.position.z - (particleGenerationRing.localScale.z / 2) + _offSet;
            for (int i = 0; i < 20;)
            {
                var xPosition = Random.Range(spawnPointLeft, spawnPointRight);
                var yPosition = -4;
                var zPosition = Random.Range(spawnPointBottom, spawnPointTop);
                var position = new Vector3(xPosition, yPosition, zPosition);
                if (isPlaceAvaible.ContainsKey(position) == false)
                {
                    MonoBehaviour.Instantiate(particle, position, Quaternion.identity, folderLocation);
                    isPlaceAvaible.Add(position, true);
                    i++;
                }
            }
        }
    }
}
