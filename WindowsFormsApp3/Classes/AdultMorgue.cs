using System;
using WindowsFormsApp2.classes;

namespace Classes
{
    [Serializable]
    class AdultMorgue : Morgue
    {
        protected int numberOfCryingWifes { get; set; }
        protected int numberOfCryingHusbands { get; set; }
        protected Person medicForAdults {  get; set; }
        public AdultMorgue(string location, int numberOfCorpses, int numberOfCeels, int numberOfCryingWifes, int numberOfCryingHusbands, Person medicForAdults, Person security)
        {
            this.location = location;
            this.numberOfCorpses = numberOfCorpses;
            this.numberOfCeels = numberOfCeels;
            this.numberOfCryingWifes = numberOfCryingWifes;
            this.numberOfCryingHusbands = numberOfCryingHusbands;
            this.medicForAdults = medicForAdults;
            this.security = security;
        }
    }
}
