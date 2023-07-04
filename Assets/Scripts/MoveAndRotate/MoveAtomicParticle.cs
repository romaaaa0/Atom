using UnityEngine;

namespace Assets
{
    public class MoveAtomicParticle : IMoving
    {
        private LayerMask _layerMask;
        private int _distance = 1000;
        public MoveAtomicParticle(LayerMask layerMask)
        {
            _layerMask = layerMask;
        }
        public void Moving()
        {
            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, _distance, _layerMask))
            {
                if (InformationAtom.IsParticleSelect == true && hit.collider.gameObject != InformationAtom.SelectedParticle)
                {
                    InformationAtom.SelectedParticle.transform.position = new Vector3(hit.point.x, hit.point.y + 0.1f, hit.point.z);
                }
            }
        }
    }
}
