using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class UI : MonoBehaviour
    {
        [SerializeField] private Text completeAtom;
        [SerializeField] private Text atomName;
        [SerializeField] private Text atomMass;
        [SerializeField] private Text proton;
        [SerializeField] private Text neutron;
        [SerializeField] private Text electron;
        [SerializeField] private Text mistake;
        public static UI Instance;
        private void Awake()
        {
            Instance = this;
        }
        private void Update()
        {
            proton.text = InformationAtom.NumberProtons.ToString();
            neutron.text = InformationAtom.NumberNeutrons.ToString();
            electron.text = InformationAtom.NumberElectrons.ToString();
            mistake.text = InformationAtom.NumberMistakes.ToString();
        }
        public void CountParticles()
        {

        }
        public void FillParameters(string atomName, string atomMass)
        {
            this.atomMass.text = atomMass;
            this.atomName.text = atomName;
        }
        public void CompleteAtom()
        {
            completeAtom.gameObject.SetActive(true);
        }
        public void LoseGame()
        {
            completeAtom.text = "Атом складено не правильно";
            completeAtom.gameObject.SetActive(true);
        }
    }
}
