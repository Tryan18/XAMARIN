using System;

namespace PolymorphDier
{
	public abstract class Dier
	{
		//Velden,Variables,Members
		private int leeftijd;
		private string naam;
		private Richting positie;

		//Property
		public Richting Positie 
		{
			get {
				return positie;
			}
			set {
				positie = value;
			}
		}


		public Dier ()
		{
			positie = Richting.Standaard;
		}

		public virtual string verplaatsen()
		{
			return positie.ToString ();
		}
	}
}

