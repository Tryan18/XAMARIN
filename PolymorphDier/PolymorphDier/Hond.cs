using System;

namespace PolymorphDier
{
	public class Hond : Dier
	{
		private int snuitLengte;


		public Hond ()
		{
		}

		public override string verplaatsen()
		{
			Positie = Richting.Boven;
			return base.verplaatsen ();
		}
	}
}

