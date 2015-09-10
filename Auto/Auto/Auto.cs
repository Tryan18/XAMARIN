using System;

namespace Auto
{
	//Superclass (A.K.A. baseclass, abstractclass)
	public abstract class Auto
	{
		//Variable
		private string naam;
		private int vermogen;
		private string kleur;
		private int aantalDeuren;
		private int inhoudTank;

		//Constructor
		public Auto ()
		{
		}

		//Method 
		public void Rij()
		{

		}

		public void Parkeren()
		{

		}

		public bool OpenDeur()
		{
			return true;
		}
	}
}

