using System;

namespace AbstractieVoorbeeld
{
	public abstract class StaffMember
	{
		private string staffName;
		private int staffNo;
		private string staffStartDate;

		public string StaffName 
		{
			get {
				return staffName;
			}
		}

		public int StaffNo
		{
			set 
			{
				staffNo = value;
			}
		}

		public string StaffStartDate 
		{
			get {
				return staffStartDate;
			}
			set {
				staffStartDate = value;
			}
		}

		public void calculateBonus()
		{
			
		}

		public void assignNewStaffGrade()
		{
			
		}
	}
}

