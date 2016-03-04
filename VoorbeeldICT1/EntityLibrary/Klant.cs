using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class Klant
    {
        private string naam;
        private string straat;
        private string postcode;
        private List<Campagne> campagnes;
        private int currentCampagne;

        public Klant(string naam)
        {
            this.naam = naam;
            this.straat = "Markt 16";
            this.postcode = "1234AA";
            this.campagnes = new List<Campagne>();
            this.campagnes.Add(new Campagne("A"));
            this.campagnes.Add(new Campagne("B"));
            this.campagnes.Add(new Campagne("C"));
            this.currentCampagne = 1;
        }

        public void SelecteerCampagne(string campagneNaam)
        {
            currentCampagne = 2;
        }

        public void AddAdvertentie(string advertentieNaam, string advertentieMedium, string advertentieContent, string advertentieOntwerper)
        {
            this.campagnes[this.currentCampagne].AddAdvertentie(
                 advertentieNaam, advertentieMedium, advertentieContent, advertentieOntwerper);
        }
    }
}
