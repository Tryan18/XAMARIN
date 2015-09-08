using System;
using System.Collections.Generic;

namespace ConsoleOutput
{
	public class Robot
	{
		private int richting;
		private int plaats;
		private List<int> geschiedenis = null;

		//Constructor
		public Robot (int plaats, int richting)
		{
			this.plaats = plaats;
			this.richting = richting;
			geschiedenis = new List<int>();
		}

		public void zetEenStap()
		{
			geschiedenis.Add (plaats);
			plaats++;
		}

		public void gaNaar(int bestemming)
		{
			plaats = bestemming;
		}

		public string print()
		{
			//lijst converteren naar string
			string geschiedenis_tekst = "";
			for (int i = 0; i < geschiedenis.Count; i++) {
				geschiedenis_tekst += geschiedenis [i].ToString () + ",";
			}

			//string om te printen
			string s = "Richting: " + richting + " Plaats: " + plaats + " Geschiedenis: " +
			           geschiedenis_tekst;
				
			return s;
		}
	}
}











