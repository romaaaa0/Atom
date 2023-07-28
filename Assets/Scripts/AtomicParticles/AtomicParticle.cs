using UnityEngine;

namespace Assets
{
    public abstract class AtomicParticle : MonoBehaviour
    {
        public Vector3 PlacePosition { get; set; }
        public bool IsParticleSelect { get; set; }
        [SerializeField] private Transform particleGenerationRing;
        private float _extremePointOfSpawnLeft;
        private float _extremePointOfSpawnRight;
        private float _extremePointOfSpawnTop;
        private float _extremePointOfSpawnBottom;
        protected bool isParticleOnGround;
        private IAttraction _attraction;
        private bool _canFunctionRun;
        private float _offSet = 2;
        public Vector3 accelaration;
        protected virtual void Start()
        {
            _attraction = new ParticleAttraction();
            _extremePointOfSpawnLeft = particleGenerationRing.position.x - (particleGenerationRing.localScale.x / 2) - _offSet;
            _extremePointOfSpawnRight = particleGenerationRing.position.x + (particleGenerationRing.localScale.x / 2) + _offSet;
            _extremePointOfSpawnBottom = particleGenerationRing.position.z - (particleGenerationRing.localScale.z / 2) - _offSet;
            _extremePointOfSpawnTop = particleGenerationRing.position.z + (particleGenerationRing.localScale.z / 2) + _offSet;
        }
        protected virtual void Update()
        {
            IsParticleOnGround();
            Attraction();
        }
        private void IsParticleOnGround()
        {
            if (transform.position.y > -2f)
                isParticleOnGround = false;
            else
                isParticleOnGround = true;
        }
        private void Attraction()
        {
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
            if (transform.position.x > _extremePointOfSpawnLeft && transform.position.x < _extremePointOfSpawnRight &&
                transform.position.z > _extremePointOfSpawnBottom && transform.position.z < _extremePointOfSpawnTop)
            {
                return true;
            }
            else
            {
                _canFunctionRun = false;
                return false;
            }
        }
        private void Accelaration()
        {
            accelaration = Input.acceleration;
            if (GetComponent<Rigidbody>())
                GetComponent<Rigidbody>().velocity += accelaration;
        }
    }
}
