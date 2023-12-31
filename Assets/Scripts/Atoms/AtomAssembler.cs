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
        [SerializeField] private Electron electron;
        [SerializeField] private Proton proton;
        [SerializeField] private Neutron neutron;
        [SerializeField] private Transform electronGenerationRing;
        [SerializeField] private Transform protonGenerationRing;
        [SerializeField] private Transform neutronGenerationRing;
        [SerializeField] private Transform folderLocation;
        private IChoosing _choosing;
        private IMoving _moveElectron;
        private IMoving _moveNeutron;
        private IMoving _moveProton;
        private IChecking _cheking;
        private IRotation _rotation;
        private IAttraction _attraction;
        private ICreator _creator;
        private void Start()
        {
            _choosing = new ChoosingAtomicParticles(layerMaskAtom);
            _moveElectron = new MoveElectron(layerMaskGround);
            _moveNeutron = new MoveNeutron(layerMaskGround);
            _moveProton = new MoveProton(layerMaskGround);
            _cheking = new CheckingCorrenctnessAtom(orbits, core); 
            _rotation = new AtomRotation();
            _attraction = new ParticleAttraction();
            CreateElectron();
            CreateNeutron();
            CreateProton();
        }
        private void Update()
        {
            _choosing.Choosing();
            _moveElectron.Moving();
            _moveNeutron.Moving();
            _moveProton.Moving();
            _cheking.Check();
            _rotation.Rotate(mainCamera);
            if (InformationAtom.IsAtomAssembled)
                Invoke(nameof(LoadMenu), 2f);
            if(InformationAtom.SelectedParticle != null && InformationAtom.SelectedParticle.transform.position == InformationAtom.ParticlePlacePosition)
                InformationAtom.SelectedParticle = null;
            IsParticleOnGround.IsSelectParticleOnGround();
        }
        private void LoadMenu()
        {
            LoadScene.Menu();
            InformationAtom.Reset();
        }
        private void CreateElectron()
        {
            _creator = new ElectronCreator(electron, electronGenerationRing, folderLocation);
            _creator.CreateParticle();
        }
        private void CreateProton()
        {
            _creator = new ProtonCreator(proton, protonGenerationRing, folderLocation);
            _creator.CreateParticle();
        }
        private void CreateNeutron()
        {
            _creator = new NeutronCreator(neutron, neutronGenerationRing, folderLocation);
            _creator.CreateParticle();
        }
    }
}
