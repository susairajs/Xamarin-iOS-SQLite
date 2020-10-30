using System;
using UIKit;
using System.IO;
using SQLite;

namespace XamariniOSSQLite
{
	public partial class ViewController : UIViewController
	{
		public static string DbName = "SQLitedb.db3";
		public static string DbPath =Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),DbName);
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		partial void BtnInsert_TouchUpInside(UIButton sender)
		{
			InsertData();
		}

		partial void BtnCreate_TouchUpInside(UIButton sender)
		{
			CreateDB();
		}

		/// Create Database 
		public void CreateDB()
		{
			try
			{
				var db = new SQLiteConnection(DbPath);
				db.CreateTable<Student>();
				lblDBName.Text = "DB Path:" + DbPath;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
		}

		/// Insert Data to Database
		public void InsertData()
		{
			try
			{
				string name = txtName.Text;
				string age = txtAge.Text;
				var student = new Student { Name = name, Age = age };
				var db = new SQLiteConnection(DbPath);
				db.Insert(student);
				lblDisplay.Text = name + ":" + age;
				
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
