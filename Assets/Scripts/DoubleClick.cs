using System;
using UnityEngine;

namespace Assets
{
    public class DoubleClick
    {
        private float lastClickTime;
        private float doubleClickDelay = 0.2f;
        public void OnMouseDown(Action putParticle)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Time.time - lastClickTime < doubleClickDelay)
                {
                    putParticle.Invoke();
                }
                lastClickTime = Time.time;
            }
        }
    }
}
