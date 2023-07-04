using UnityEngine;

namespace Assets
{
    public class Creator : MonoBehaviour
    {
        [SerializeField] private Electron electron;
        [SerializeField] private Proton proton;
        [SerializeField] private Neutron neutron;
        [SerializeField] private Transform electronGenerationRing;
        [SerializeField] private Transform protonGenerationRing;
        [SerializeField] private Transform neutronGenerationRing;
        [SerializeField] private Transform folderLocation;
        private ICreator _creator;
        private void Start()
        {
            CreateProton();
            CreateElectron();
            CreateNeutron();
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