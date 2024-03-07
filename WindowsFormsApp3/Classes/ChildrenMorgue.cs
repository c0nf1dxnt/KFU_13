using System;
using WindowsFormsApp2.classes;

namespace Classes
{
    [Serializable]
    class ChildrenMorgue : Morgue
    {
        protected int numberOfCryingMothers { get; set; }
        protected int numberOfCryingDads { get; set; }
        protected Person medicForChildren { get; set; }
        public ChildrenMorgue(string location, int numberOfCorpses, int numberOfCeels, int numberOfCryingMothers, int numberOfCryingDads, Person medicForChildren, Person security)
        {
            this.location = location;
            this.numberOfCorpses = numberOfCorpses;
            this.numberOfCeels = numberOfCeels;
            this.numberOfCryingMothers = numberOfCryingMothers;
            this.numberOfCryingDads = numberOfCryingDads;
            this.medicForChildren = medicForChildren;
            this.security = security;
        }
    }
}
