using System;
using WindowsFormsApp2.classes;

namespace Classes
{
    [Serializable]
    class AnimalMorgue : Morgue
    {
        protected int numberOfCryingOwners { get; set; }
        protected int numberOfVets { get; set; }
        protected Person vet { get; set; }
        public AnimalMorgue(string location, int numberOfCorpses, int numberOfCeels, int numberOfCryingOwners, int numberOfVets, Person vet, Person security) 
        {
            this.location = location;
            this.numberOfCorpses = numberOfCorpses;
            this.numberOfCeels = numberOfCeels;
            this.numberOfCryingOwners = numberOfCryingOwners;
            this.numberOfVets = numberOfVets;
            this.vet = vet;
            this.security = security;
        }
    }
}
