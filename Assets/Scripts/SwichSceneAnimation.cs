using UnityEngine;

namespace Assets
{
    public class SwichSceneAnimation : MonoBehaviour
    {
        private void Start()
        {
            GetComponent<Animator>().Play("Start");       
        }
    }
}
