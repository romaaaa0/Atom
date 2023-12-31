﻿using UnityEngine;
using System;

namespace Assets
{
    public static class InformationAtom
    {
        public static GameObject SelectedParticle { get; set; }
        public static bool IsParticleSelect { get; set; }
        public static bool IsAtomAssembled { get; set; }
        public static bool IsParticleOnGround { get; set; }
        public static string AtomName { get; set; }
        public static int AtomNumber
        {
            get { return _atomNumber; }
            set
            {
                if (_atomNumber < 1 || _atomNumber > 118)
                    throw new ArgumentException();
                else
                    _atomNumber = value;
            }
        }
        private static int _atomNumber = 1;
        public static string AtomMass { get; set; }
        public static int NumberProtons
        {
            get { return _numberProtons; }
            set
            {
                if (_numberProtons < 1 || _numberProtons > 118)
                    throw new ArgumentException();
                else
                    _numberProtons = value;
            }
        }
        private static int _numberProtons = 1;
        public static int NumberNeutrons
        {
            get { return _numberNeutrons; }
            set
            {
                if (_numberNeutrons < 0 || _numberNeutrons > 177)
                    throw new ArgumentException();
                else
                    _numberNeutrons = value;
            }
        }
        private static int _numberNeutrons;
        public static int NumberElectrons
        {
            get { return _numberElectrons; }
            set
            {
                if (_numberElectrons < 0 || _numberElectrons > 118)
                    throw new ArgumentException();
                else
                    _numberElectrons = value;
            }
        }
        private static int _numberElectrons;
        public static int NumberMistakes
        {
            get { return _numberMistakes; }
            set
            {
                if (_numberMistakes < 0)
                    throw new ArgumentException();
                else
                    _numberMistakes = value;
            }
        }
        private static int _numberMistakes;
        public static int RequiredNumberElectrons
        {
            get { return _requiredNumberElectrons; }
            set
            {
                if (_requiredNumberElectrons < 0 || _requiredNumberElectrons > 118)
                    throw new ArgumentException();
                else
                    _requiredNumberElectrons = value;
            }
        }
        private static int _requiredNumberElectrons;
        public static int RequiredNumberProtons
        {
            get { return _requiredNumberProtons; }
            set
            {
                if (_requiredNumberProtons < 0 || _requiredNumberProtons > 118)
                    throw new ArgumentException();
                else
                    _requiredNumberProtons = value;
            }
        }
        private static int _requiredNumberProtons;
        public static int RequiredNumberNeutrons
        {
            get { return _requiredNumberNeutrons; }
            set
            {
                if (_requiredNumberNeutrons < 0 || _requiredNumberNeutrons > 118)
                    throw new ArgumentException();
                else
                    _requiredNumberNeutrons = value;
            }
        }
        private static int _requiredNumberNeutrons;
        public static int HowManyOrbitsAdded
        {
            get { return _howManyOrbitsAdded; }
            set
            {
                if (_howManyOrbitsAdded < 0 || _howManyOrbitsAdded > 3)
                    throw new ArgumentException();
                else
                    _howManyOrbitsAdded = value;
            }
        }
        private static int _howManyOrbitsAdded;
        public static Vector3 ParticlePlacePosition { get; set; }
        public static void Reset()
        {
            NumberProtons = 1;
            NumberNeutrons = 0;
            NumberElectrons = 0;
            NumberMistakes = 0;
            HowManyOrbitsAdded = 0;
            SelectedParticle = null;
            IsAtomAssembled = false;
        }
    }
}
