using UnityEngine;

namespace Assets
{
    public class ChoosingAtomicParticles : IChoosing
    {
        private RaycastHit _hit;
        private AtomicParticle _particle;
        private LayerMask _layerMask;
        private int _distance = 1000;
        public ChoosingAtomicParticles(LayerMask layerMask)
        {
            _layerMask = layerMask;
        }
        public void Choosing()
        {

            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out _hit, _distance, _layerMask))
            {
                _particle = _hit.collider.gameObject.GetComponent<AtomicParticle>();
                if (InformationAtom.IsParticleSelect == true && InformationAtom.IsParticleOnGround == true && _hit.rigidbody != null)
                {
                    MonoBehaviour.Destroy(InformationAtom.SelectedParticle.GetComponent<Rigidbody>());
                }
                if (_particle != null)
                {
                    if (Input.GetMouseButtonDown(0))
                        Take();
                    else if (Input.GetMouseButtonUp(0))
                        Put();
                }
            }
        }
        private void Take()
        {
            InformationAtom.IsParticleSelect = true;
            InformationAtom.SelectedParticle = _hit.collider.gameObject;
            var particle = InformationAtom.SelectedParticle.GetComponent<AtomicParticle>();
            particle.IsParticleSelect = true;
            InformationAtom.ParticlePlacePosition = particle.PlacePosition;
            InformationAtom.SelectedParticle.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }
        private void Put()
        {
            InformationAtom.IsParticleSelect = false;
            if (InformationAtom.SelectedParticle == null)
                Debug.Log("Null");
            else
                InformationAtom.SelectedParticle.GetComponent<AtomicParticle>().IsParticleSelect = false;
            if (InformationAtom.IsParticleOnGround)
            {
                if (_hit.rigidbody == null) 
                    _hit.collider.gameObject.AddComponent<Rigidbody>();
                _hit.rigidbody.useGravity = true;
                _hit.collider.isTrigger = false;
                _hit.rigidbody.isKinematic = false;
                InformationAtom.SelectedParticle.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            }
            else
            {
                if(_hit.rigidbody == null)
                    _hit.collider.gameObject.AddComponent<Rigidbody>();
                _hit.rigidbody.useGravity = false;
                _hit.collider.isTrigger = true;
                _hit.rigidbody.isKinematic = true;
                InformationAtom.SelectedParticle = null;
            }
        }
    }
}