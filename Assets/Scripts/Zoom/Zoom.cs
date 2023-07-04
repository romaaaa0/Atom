using System;
using UnityEngine;

namespace Assets
{
    public class Zoom : MonoBehaviour
    {
        private float maxZoom = 70;
        private float minZoom = 30;
        private void Update()
        {
            var localMousePosition = Input.mousePosition;
            localMousePosition.z = 10f;
            var worldMousePosition = Camera.main.ScreenToWorldPoint(localMousePosition);
            if(Input.touchCount == 2)
            {
                var touchZero = Input.GetTouch(0);
                var touchOne = Input.GetTouch(1);
                var touchZeroLastPosition = touchZero.position - touchZero.deltaPosition;
                var touchOneLastPosition = touchOne.position - touchOne.deltaPosition;
                var distanceTouch = (touchZeroLastPosition - touchOneLastPosition).magnitude;
                var currentdistanceTouch = (touchZero.position - touchOne.position).magnitude;
                var difference = distanceTouch - currentdistanceTouch;
                ZoomCamera(difference * 0.01f);
            }
            ZoomCamera(Input.GetAxis("Mouse ScrollWheel") * 3);
        }
        private void ZoomCamera(float increment)
        {
            Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView - increment, minZoom, maxZoom);
        }
    }
}
