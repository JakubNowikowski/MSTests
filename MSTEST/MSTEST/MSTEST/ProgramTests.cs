using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using Moq;

namespace MSTEST
{
	[TestClass]
	public class ProgramTests
	{
		[TestMethod]
		public void GetNameById_moq()
		{
			var mock = new Mock<IGetDataRepository>();
			mock.Setup(p => p.GetNameById(1)).Returns("John");
			Program program = new Program(mock.Object);

			string result = program.GetNameById(1);
			Assert.AreEqual("John",result);

		}

		[TestMethod]
		public void GetNameById_fake()
		{
			
		}
	}
}
