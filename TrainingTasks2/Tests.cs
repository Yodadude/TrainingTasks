using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TrainingTasks2.SRP;

namespace TrainingTasks2
{
    [TestFixture]
    public class Task2Tests
    {

		[Test]
		public void SRP_Email_Validator()
		{
			var val = new EmailValidator();
	
			Assert.IsFalse(val.IsValid("xxxx"));
			Assert.AreEqual(val.Message, "Email is not an email!");

		}

		[Test]
		public void SRP_Email_Validator_Valid()
		{
			var val = new EmailValidator();

			Assert.IsTrue(val.IsValid("john.byrne@inlogik"));
		}

		[Test]
		public void SRP_User_Service_Email_Exception()
		{
			var us = new UserService();
			var ex = Assert.Throws(typeof(Exception), () => us.Register("xxxx", "xxxx"));

			Assert.AreEqual(ex.Message, "Email is not an email!");
			
		}
    }
}
