using UnityEngine;

namespace Assets
{
    public class AtomRotation : IRotation
    {
        private float _speedRotation = 1;
        private float _speedToTarget = 1.5f;
        private Vector3 _target;
        private float _speedMouseAxisX = 0.1f;
        private float _speedMouseAxisY = 0.1f;
        private Vector3 MousePosition()
        {
            var localMousePosition = Input.mousePosition;
            localMousePosition.z = 10;
            return Camera.main.ScreenToWorldPoint(localMousePosition);
        }
        public void Rotate(Transform transform)
        {
            if (InformationAtom.IsParticleSelect == true) return;
            if (Input.GetMouseButton(0))
            {
                if (Input.GetAxis("Mouse X") > _speedMouseAxisX || Input.GetAxis("Mouse X") < -_speedMouseAxisX)
                {
                    if (Input.GetAxis("Mouse X") > _speedMouseAxisX)
                        _target -= new Vector3(0, _speedRotation, 0);
                    else if (Input.GetAxis("Mouse X") < -_speedMouseAxisX)
                        _target += new Vector3(0, _speedRotation, 0);
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
            _target.y = Mathf.Clamp(_target.y, -360, 360);
            _target.z = Mathf.Clamp(_target.z, -0.1f, 0.1f);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(new Vector3(_target.x, _target.y, 0)), _speedToTarget * Time.deltaTime);
        }
    }
}
