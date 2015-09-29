using System;

namespace CC_AddAdvert
{
	public class CC_AddAdvert
	{
		public delegate void ActieHandler(string test);
		public event ActieHandler ActieGebeurtenis;

		public CC_AddAdvert ()
		{
		}

		public void Test() 
		{
			string s = "hallo";
			ActieGebeurtenis (s);
		}
	}
}

