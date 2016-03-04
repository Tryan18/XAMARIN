using System;
using BU;
using System.IO;
using System.Collections.Generic;

namespace CC
{
	public class ManagePersons
	{
		bool databaseCreated = false;

		private string GetDatabasePath()
		{
			string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			string filename = System.IO.Path.Combine(path, "sqlite.db");
			return filename;
		}

		private void CreateTable()
		{
			using (var conn = new SQLite.SQLiteConnection(GetDatabasePath()))
			{
				conn.CreateTable<Person>();
			}
		}

		public void InsertPerson()
		{
			if (!databaseCreated) 
			{
				if(File.Exists(GetDatabasePath ()))
					File.Delete (GetDatabasePath ());
				CreateTable ();
				databaseCreated = true;
			}

			var person = new Person { FirstName = "John", LastName = "Doe", TimeStamp = DateTime.Now.Ticks.ToString()};
			using (var db = new SQLite.SQLiteConnection(GetDatabasePath() ))
			{
				db.Insert(person);
			}
		}

		public string GetLastPersonName()//(int ID)
		{
			if (databaseCreated) 
			{
				using (var db = new SQLite.SQLiteConnection (GetDatabasePath ())) 
				{
					List<Person> persons = db.Query<Person> ("SELECT * FROM PERSON WHERE FIRSTNAME = 'John' ORDER BY ID DESC LIMIT 1");
					if (persons.Count > 0) 
					{
						Person p = persons [0];
						//Also possible method solution
						//Person p = db.Get<Person> (ID);
						string name = p.FirstName + " " + p.LastName + Environment.NewLine + "TimeStamp: " + p.TimeStamp;
						return name;
					}
				}
			}
			return "";
		}

		public void ClearDatabase()
		{
			if (databaseCreated) 
			{
				using (var db = new SQLite.SQLiteConnection (GetDatabasePath ())) 
				{
					db.Execute ("Delete from Person");
				}
			}
		}
	}
}

