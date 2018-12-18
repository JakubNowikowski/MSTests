using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Program
	{
		private readonly IGetDataRepository _data;

		public Program(IGetDataRepository data)
		{
			_data = data;
		}

		public string GetNameById(int id)
		{
			return _data.GetNameById(id);
		}

		static void Main(string[] args)
		{
		//	string fileName = null;

		//	LoadDxfFile loadDxf = new LoadDxfFile();

		//	loadDxf.IsValidFileName(fileName);
		}
	}
}
