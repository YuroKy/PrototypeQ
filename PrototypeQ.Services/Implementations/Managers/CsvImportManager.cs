using System.Collections.Generic;
using PrototypeQ.Data.Models;
using PrototypeQ.Services.Abstractions.Managers;
using PrototypeQ.Services.Abstractions.Strategies;

namespace PrototypeQ.Services.Implementations.Managers
{
	public class CsvImportManager : IFileImportManager
	{
		private readonly ICsvReadingStrategy _readingStrategy;

		public CsvImportManager(ICsvReadingStrategy readingStrategy)
		{
			_readingStrategy = readingStrategy;
		}

		public List<PersonModel> Import(string path)
		{
			return _readingStrategy.Read(path);
		}
	}
}
