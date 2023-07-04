using System.Collections.Generic;

namespace Assets
{
    public class ChangeTypeOfAtom
    {
        public enum TypeOfAtom
        {
            Hydrogen, Helium, Lithium, Beryllium, Boron
        }
        public static TypeOfAtom Type;
        public Dictionary<TypeOfAtom, TypeOfAtom> NextAtom = new Dictionary<TypeOfAtom, TypeOfAtom>();
        public ChangeTypeOfAtom()
        {
            AddNextAtom();
            ChangeAtom();
        }
        private void ChangeAtom()
        {
            switch (Type)
            {
                case TypeOfAtom.Hydrogen:
                    new Hydrogen();
                    break;
                case TypeOfAtom.Helium:
                    new Helium();
                    break;
                case TypeOfAtom.Lithium:
                    new Lithium();
                    break;
                case TypeOfAtom.Beryllium:
                    new Beryllium();
                    break;
                case TypeOfAtom.Boron:
                    new Boron();
                    break;
            }
        }
        private void AddNextAtom()
        {
            NextAtom.Add(TypeOfAtom.Hydrogen, TypeOfAtom.Helium);
            NextAtom.Add(TypeOfAtom.Helium, TypeOfAtom.Lithium);
            NextAtom.Add(TypeOfAtom.Lithium, TypeOfAtom.Beryllium);
            NextAtom.Add(TypeOfAtom.Beryllium, TypeOfAtom.Boron);
        }
    }
}
