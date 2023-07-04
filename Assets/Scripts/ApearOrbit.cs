using UnityEngine;

namespace Assets
{
    public class ApearOrbit : MonoBehaviour, IApear
    {
        public void Apear(GameObject orbit)
        {

            orbit.SetActive(true);
            orbit.GetComponent<Animator>().Play("ApearOrbit");
        }
    }
}
