using System.Collections.Generic;
using System.IO;
using System.Linq;
using PrototypeQ.DataModel.Models;
using PrototypeQ.Services.Abstractions.Managers;
using PrototypeQ.Services.Mappers;

namespace PrototypeQ.Services.Implementations.Managers
{
	public class CsvImportManager : IFileImportManager
	{
		public List<PersonModel> Import(string path)
		{
			var lines = File.ReadAllLines(path);

			return  lines
				.Select(row => row.Split(','))
				.Select(PersonMapper.ToPersonModel)
				.ToList();
		}
	}
}
