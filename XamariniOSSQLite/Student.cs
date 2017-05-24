using System;
using SQLite;
namespace XamariniOSSQLite
{
	public class Student
	{
		[PrimaryKey,AutoIncrement]
		public int id { get; set; }
		public string Name { get; set;}
		public string Age { get; set;}
	}
}
