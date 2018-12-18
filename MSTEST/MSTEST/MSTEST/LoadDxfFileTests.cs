using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using Moq;

namespace MSTEST
{
	[TestClass]
	public class LoadDxfFileTests
	{
		private LoadDxfFile MakeLoadDxf()
		{
			return new LoadDxfFile();
		}

		[TestMethod]
		public void IsValidFileName_EmptyFileName_ThrowsExepction()
		{
			LoadDxfFile la = MakeLoadDxf();

			var ex = Assert.ThrowsException<ArgumentException>(() => la.IsValidFileName(""));

			//StringAssert.Contains("filename has to be provided", ex.Message);

			Assert.AreEqual(ex.Message, ("filename has to be provided"));
		}


		[DataTestMethod]
		[DataRow("goodextensionfile.DXF")]
		[DataRow("goodextensionfile.dxf")]
		public void IsValidFileName_ValidExtensions_ReturnsTrue(string file)
		{
			LoadDxfFile ld = MakeLoadDxf();

			bool result = ld.IsValidFileName(file);

			Assert.IsTrue(result);

		}

		[TestMethod]
		public void IsValidFileName_BadExtension_ReturnsFalse()
		{
			LoadDxfFile la = MakeLoadDxf();

			bool result = la.IsValidFileName("badextensionfile.foo");

			Assert.IsFalse(result);
		}

	}
}
