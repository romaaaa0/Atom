using UnityEngine;

namespace Assets
{
    public class MoveNeutron : IMoving
    {
        private LayerMask _layerMask;
        private int _distance = 1000;
        public MoveNeutron(LayerMask layerMask)
        {
            _layerMask = layerMask;
        }
        public void Moving()
        {
            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, _distance, _layerMask))
            {
                if (InformationAtom.IsParticleSelect == true && InformationAtom.SelectedParticle.GetComponent<Neutron>() 
                    && !hit.collider.gameObject.GetComponent<Neutron>()
                    && !hit.collider.gameObject.GetComponent<Electron>())
                {
                    InformationAtom.SelectedParticle.transform.position = new Vector3(hit.point.x, hit.point.y + 0.1f, hit.point.z);
                }
            }
        }
    }
}
