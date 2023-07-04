using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets
{
    public class LoadScene : MonoBehaviour
    {
        public void Hydrogen()
        {
            SceneManager.LoadScene(1);
            ChangeTypeOfAtom.Type = ChangeTypeOfAtom.TypeOfAtom.Hydrogen;
        }
        public void Helium()
        {
            SceneManager.LoadScene(1);
            ChangeTypeOfAtom.Type = ChangeTypeOfAtom.TypeOfAtom.Helium;
        }
        public void Lithium()
        {
            SceneManager.LoadScene(1);
            ChangeTypeOfAtom.Type = ChangeTypeOfAtom.TypeOfAtom.Lithium;
        }
        public void Beryllium()
        {
            SceneManager.LoadScene(1);
            ChangeTypeOfAtom.Type = ChangeTypeOfAtom.TypeOfAtom.Beryllium;
        }
        public void Boron()
        {
            SceneManager.LoadScene(1);
            ChangeTypeOfAtom.Type = ChangeTypeOfAtom.TypeOfAtom.Boron;
        }
        public static void Menu()
        {
            SceneManager.LoadScene(0);
            InformationAtom.Reset();
        }
    }
}
