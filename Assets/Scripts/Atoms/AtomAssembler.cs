﻿using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public class AtomAssembler : MonoBehaviour
    {
        [SerializeField] private List<GameObject> orbits = new List<GameObject>();
        [SerializeField] private LayerMask layerMaskAtom;
        [SerializeField] private LayerMask layerMaskGround;
        [SerializeField] private GameObject core;
        [SerializeField] private Transform mainCamera;
        private IChoosing _choosing;
        private IMoving _moving;
        private IChecking _cheking;
        private IRotation _rotation;
        private IAttraction _attraction;
        private void Start()
        {
            new ChangeTypeOfAtom();
            _choosing = new ChoosingAtomicParticles(layerMaskAtom);
            _moving = new MoveAtomicParticle(layerMaskGround);
            _cheking = new CheckingCorrenctnessAtom(orbits, core); 
            _rotation = new AtomRotation();
            _attraction = new ParticleAttraction();
        }
        private void Update()
        {
            _choosing.Choosing();
            _moving.Moving();
            _cheking.Check();
            _rotation.Rotate(mainCamera);
            if (InformationAtom.IsAtomAssembled)
                Invoke(nameof(LoadMenu), 2f);
            if(InformationAtom.SelectedParticle != null && InformationAtom.SelectedParticle.transform.position == InformationAtom.ParticlePlacePosition)
                InformationAtom.SelectedParticle = null;
        }
        private void LoadMenu()
        {
            LoadScene.Menu();
            InformationAtom.Reset();
        }
    }
}
