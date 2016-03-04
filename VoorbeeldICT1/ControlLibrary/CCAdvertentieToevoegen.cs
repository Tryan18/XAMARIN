using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary;

namespace ControlLibrary
{
    public class CCAdvertentieToevoegen
    {
        private Klant klant;



        public CCAdvertentieToevoegen(
            string klantNaam, string campagneNaam)
        {
            this.klant = new Klant(klantNaam);
            this.klant.SelecteerCampagne(campagneNaam);

        }

        /*
         * AddAdvertentie(
                tbAdvertentieNaam.Text,
                tbAdvertentieMedium.Text,
                tbAdvertentieContent.Text,
                tbAdvertentieOntwerper.Text);
         * 
         */

        public void AddAdvertentie(
             string advertentieNaam,
             string advertentieMedium,
             string advertentieContent,
             string advertentieOntwerper)
        {
            this.klant.AddAdvertentie(advertentieNaam,
                                      advertentieMedium,
                                      advertentieContent,
                                      advertentieOntwerper);
        }

        public void AddAdvertentie(Dictionary<string, string> data)
        {
            throw new NotImplementedException();
        }
    }
}
