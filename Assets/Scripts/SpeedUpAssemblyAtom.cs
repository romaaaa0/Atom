using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class SpeedUpAssemblyAtom : MonoBehaviour
    {
        [SerializeField] private GameObject currentAtom;
        [SerializeField] private List<GameObject> newAtoms;
        [SerializeField] private GameObject speedUpAssemblyButton;
        [SerializeField] private Animator backgroundAnimator;
        [SerializeField] private Button button;
        private float _timer = 1f;
        private bool _canFunctionWork = true;
        private bool _canFunctionWork2 = true;
        private bool _wasClickOnButton;
        private void Start()
        {
            if (InformationAtom.AtomNumber > 3)
                speedUpAssemblyButton.SetActive(true);
        }
        private void Update()
        {
            AddElectron();
            SpeedUpAssembly();
        }
        public void Click()
        {
            backgroundAnimator.Play("Transition");
            _wasClickOnButton = true;
            button.gameObject.SetActive(false);
        }
        private void SpeedUpAssembly()
        {
            if (!_wasClickOnButton) return;
            _timer -= Time.deltaTime;
            if (_timer < 0)
            {
                currentAtom.SetActive(false);
                var newAtom = newAtoms[InformationAtom.AtomNumber - 2];
                Instantiate(newAtom, new Vector3(0, 0, 0), Quaternion.identity);
                var iSpeedUpAssembly = newAtom.GetComponent<ISpeedUpAssembly>();
                if (iSpeedUpAssembly != null)
                    iSpeedUpAssembly.SetRequireValues();
                _wasClickOnButton = false;
            }
        }
        private void AddElectron()
        {
            if (InformationAtom.HowManyOrbitsAdded == 1 && _canFunctionWork == true)
            {
                InformationAtom.NumberElectrons++;
                _canFunctionWork = false;
            }
            if (InformationAtom.HowManyOrbitsAdded == 2 && _canFunctionWork2 == true)
            {
                InformationAtom.NumberElectrons += InformationAtom.AtomNumber - 3;
                _canFunctionWork2 = false;
            }
        }
    }
}
