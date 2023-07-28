using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets
{
    public class LoadScene : MonoBehaviour
    {
        public void Hydrogen()
        {
            SceneManager.LoadScene(1);
        }
        public void Helium()
        {
            SceneManager.LoadScene(1);
        }
        public void Lithium()
        {
            SceneManager.LoadScene(1);
        }
        public void Beryllium()
        {
            SceneManager.LoadScene(1);
        }
        public void Boron()
        {
            SceneManager.LoadScene(1);
        }
        public static void Menu()
        {
            SceneManager.LoadScene(0);
            InformationAtom.Reset();
        }
    }
}
