using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrainingTasks2.SRP
{
	public class SaveUser
	{
		public void Save(String email, String password)
		{
			var user = new User(email, password);
			var db = new FakeDatabase();
			db.Save(user);
		}
	}
}
