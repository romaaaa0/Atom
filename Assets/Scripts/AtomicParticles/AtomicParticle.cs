using UnityEngine;

namespace Assets
{
    public abstract class AtomicParticle : MonoBehaviour
    {
        public Vector3 PlacePosition { get; set; }
        public bool IsParticleSelect { get; set; }
        [SerializeField] private Transform particleGenerationRing;
        private float ExtremePointOfSpawnLeft;
        private float ExtremePointOfSpawnRight;
        private float ExtremePointOfSpawnTop;
        private float ExtremePointOfSpawnBottom;
        protected bool isParticleOnGround;
        private IAttraction _attraction;
        private bool _canFunctionRun;
        protected virtual void Start()
        {
            _attraction = new ParticleAttraction();
            ExtremePointOfSpawnLeft = (particleGenerationRing.position.x - (particleGenerationRing.localScale.x / 2)) - 2;
            ExtremePointOfSpawnRight = (particleGenerationRing.position.x + (particleGenerationRing.localScale.x / 2)) + 2;
            ExtremePointOfSpawnBottom = (particleGenerationRing.position.z - (particleGenerationRing.localScale.z / 2)) - 2;
            ExtremePointOfSpawnTop = (particleGenerationRing.position.z + (particleGenerationRing.localScale.z / 2)) + 2;
            print(ExtremePointOfSpawnRight);
            print(ExtremePointOfSpawnLeft);
            print(ExtremePointOfSpawnTop);
            print(ExtremePointOfSpawnBottom);
        }
        protected virtual void Update()
        {
            if (transform.position.y > -2f)
                isParticleOnGround = false;
            else
                isParticleOnGround = true;
            if (isParticleOnGround && IsParticleSelect == false && IsObjectAtSpawnPoint() == false)
            {
                _attraction.Attraction(transform, PlacePosition, 30);
            }
            if (transform.position == PlacePosition)
                _canFunctionRun = true;
        }
        private bool IsObjectAtSpawnPoint()
        {
            if (_canFunctionRun == false)
            {
                return false;
            }
            if (transform.position.x > ExtremePointOfSpawnLeft && transform.position.x < ExtremePointOfSpawnRight &&
                transform.position.z > ExtremePointOfSpawnBottom && transform.position.z < ExtremePointOfSpawnTop)
            {
                return true;
            }
            else
            {
                _canFunctionRun = false;
                return false;
            }
        }
    }
}
