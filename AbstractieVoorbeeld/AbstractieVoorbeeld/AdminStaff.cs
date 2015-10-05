using System;

namespace AbstractieVoorbeeld
{
	public class AdminStaff : StaffInterface
	{
		public AdminStaff ()
		{
		}

		#region StaffInterface implementation

		public string getStaffName ()
		{
			throw new NotImplementedException ();
		}

		#endregion
	}
}

