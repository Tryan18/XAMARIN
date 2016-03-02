using System;
using System.Collections.Generic;

namespace PolymorphDier
{
	public class Test
	{
		List<Dier> dieren;

		public Test ()
		{
			dieren = new List<Dier>();
			for (int i = 0; i < 5; i++)
			{
				dieren.Add (new Hond ());
				dieren.Add (new Vis ());
			}
		}

		public string TestPolyMorph()
		{
			string s = "";
			foreach(Dier d in dieren)
			{
				s += d.verplaatsen () + Environment.NewLine;
			}
			return s;
		}
	}
}

