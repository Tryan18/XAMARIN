using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class Campagne
    {
        private string naam;
        private DateTime startDatum;
        private decimal budget;
        private List<Advertentie> advertenties;


        public Campagne(string naam)
        {
            this.naam = naam;
            this.startDatum = new DateTime(2015, 9, 1);
            this.budget = new decimal(1000);
            advertenties = new List<Advertentie>();
        }

        public void AddAdvertentie(string a, string b, string c, string d)
        {
            Advertentie adv = new Advertentie(a, b, c, d);
            advertenties.Add(adv);
            
        }
    }
}
