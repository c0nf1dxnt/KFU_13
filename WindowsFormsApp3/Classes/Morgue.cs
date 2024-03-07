using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.classes;

namespace Classes
{
    abstract class Morgue
    {
        protected string location { get; set; }
        protected int numberOfCorpses { get; set; }
        protected int numberOfCeels { get; set; }
        protected Person security { get; set; }

        public Morgue()
        {
            location = "unspecified";
            numberOfCorpses = 0;
            numberOfCeels = 0;
        }
        public Morgue(string location, int numberOfCorpses, int numberOfCeels)
        {
            this.location = location;
            this.numberOfCorpses = numberOfCorpses;
            this.numberOfCeels = numberOfCeels;
        }
    }
}
