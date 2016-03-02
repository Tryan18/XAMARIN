using System;

namespace PolymorphDier
{
	public class Vis : Dier
	{
		private int soortVis;
		private bool IsZoetWaterType; 

		public Vis ()
		{
			
		}

		public override string verplaatsen()
		{
			Positie = Richting.Onder;
			return base.verplaatsen ();
		}
	}
}

