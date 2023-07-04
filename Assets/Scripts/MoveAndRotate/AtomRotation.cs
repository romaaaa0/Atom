using UnityEngine;

namespace Assets
{
    public class AtomRotation : IRotation
    {
        private float _speedRotation = 0.7f;
        private float _speedToTarget = 1.5f;
        private Vector3 _target;
        private float _speedMouseAxisX = 0.1f;
        private float _speedMouseAxisY = 0.1f;
        private RaycastHit _hit;
        private bool _didMouseClickOnAtom = false;
        private Vector3 MousePosition()
        {
            var localMousePosition = Input.mousePosition;
            localMousePosition.z = 10;
            return Camera.main.ScreenToWorldPoint(localMousePosition);
        }
        public void Rotate(Transform transform)
        {
            if (InformationAtom.IsParticleSelect == true) return;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out _hit))
            {
                if (Input.GetMouseButtonDown(0) && _hit.collider.gameObject.GetComponent<AreaForRotation>())
                    _didMouseClickOnAtom = true;
                else if(Input.GetMouseButtonUp(0))
                    _didMouseClickOnAtom = false;
            }
            if (_didMouseClickOnAtom)
            {
                if (Input.GetAxis("Mouse X") > _speedMouseAxisX || Input.GetAxis("Mouse X") < -_speedMouseAxisX)
                {
                    if (Input.GetAxis("Mouse X") > _speedMouseAxisX)
                        _target += new Vector3(0, _speedRotation, 0);
                    else if (Input.GetAxis("Mouse X") < -_speedMouseAxisX)
                        _target -= new Vector3(0, _speedRotation, 0);
                    else return;
                }
                else if (Input.GetAxis("Mouse Y") > _speedMouseAxisY || Input.GetAxis("Mouse Y") < -_speedMouseAxisY)
                {
                    if (Input.GetAxis("Mouse Y") > _speedMouseAxisY)
                        _target -= new Vector3(_speedRotation, 0, 0);
                    else if (Input.GetAxis("Mouse Y") < -_speedMouseAxisY)
                        _target += new Vector3(_speedRotation, 0, 0);
                    else return;
                }
            }
            _target.x = Mathf.Clamp(_target.x, -45, 45);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(_target), _speedToTarget * Time.deltaTime);

        }
    }
}
