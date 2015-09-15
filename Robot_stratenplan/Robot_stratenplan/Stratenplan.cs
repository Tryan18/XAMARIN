using System;

namespace Robot_stratenplan
{
	public class Stratenplan
	{
		private string[,] plaats;  

		public Stratenplan ()
		{
			plaats = new string[8, 11];
			for (int i=0; i < plaats.GetLength (0); i++) {
				for (int j = 0; j < plaats.GetLength (1); j++) {
					plaats [i, j] = "O";
				}
			}

			string[] x_plaatsen = new string[] {
				"3,0",
				"3,1",   
				"3,2",
				"3,3",
				"3,4",
				"3,5",
				"3,6",
				"3,7",  
				"3,8", 
				"3,9", 
				"3,10",
				"1,0",
				"2,0",
				"4,0", 
				"5,0", 
				"0,3",
				"1,3", 
				"2,3",
				"4,5",
				"5,5",
				"6,5",
				"7,5",
				"1,8",
				"2,8",
				"4,8",
				"5,8",
				"6,8", 
				"4,10",   
				"5,10"
			};
			foreach (string s in x_plaatsen) 
			{
				string[] temp = s.Split (new string[] { "," }, StringSplitOptions.None);
				int index_x = Convert.ToInt32 (temp [0]);
				int index_y = Convert.ToInt32 (temp [1]);
				plaats [index_x, index_y] = "X";
			}
		}

		public bool bevat(int x, int y)
		{
			return true;
		}

		public string ShowPlan ()
		{
			string output = "";
			for (int i=0; i < plaats.GetLength (0); i++) {
				for (int j = plaats.GetLength (1)-1; j > 0 ; j--) {
					output += plaats [i, j] + " ";
				}
				output += Environment.NewLine;
			}
			return output;
		}
	}
}

