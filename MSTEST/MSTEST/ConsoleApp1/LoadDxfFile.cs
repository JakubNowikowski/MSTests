using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class LoadDxfFile : IGetDataRepository
	{

		public string GetNameById(int id)
		{
			string name;

			if (id == 1)
			{
				name = "John";
			}

			if (id == 2)
			{
				name = "Ben";
			}
			else
			{
				name = "not found";
			}

			return name;
		}

		public bool IsValidFileName(string fileName)
		{

			if (string.IsNullOrEmpty(fileName))
			{
				throw new ArgumentException("filename has to be provided");
			}
			if (!fileName.EndsWith(".DXF", StringComparison.CurrentCultureIgnoreCase))
			{
				return false;
			}

			return true;
		}
	}
}
