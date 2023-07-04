using System;
using UnityEngine;

namespace Assets
{
    public class WhichLevelsPassed : MonoBehaviour
    {
        [SerializeField] private GameObject lockLevel;
        private void Start()
        {
            if (PlayerPrefs.GetInt(gameObject.name) == 1)
            {
                lockLevel.SetActive(false);
            }
        }
    }
}
