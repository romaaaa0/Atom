using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public class DestroyHeards : MonoBehaviour
    {
        [SerializeField] private List<GameObject> hearts = new List<GameObject>();
        private int _numberHearts = 3;
        private UI _ui;
        private void Start()
        {
            _ui = UI.Instance;
        }
        public void DestroyHeart()
        {
            MonoBehaviour.Destroy(hearts[0]);
            hearts.RemoveAt(0);
            _numberHearts--;
            if (_numberHearts <= 0)
            {
                _ui.LoseGame();
                Invoke("Load", 2);
            }
        }
        private void Load()
        {
            LoadScene.Menu();
        }
    }
}
