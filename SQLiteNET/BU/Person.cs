using System;
using SQLite;

namespace BU
{
	public class Person
	{
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string TimeStamp {get;set;}
	}
}

