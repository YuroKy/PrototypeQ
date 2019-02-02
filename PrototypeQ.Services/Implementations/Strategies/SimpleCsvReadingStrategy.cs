using System.Collections.Generic;
using System.IO;
using System.Linq;
using PrototypeQ.Data.Models;
using PrototypeQ.Services.Abstractions.Strategies;
using PrototypeQ.Services.Implementations.Mappers;

namespace PrototypeQ.Services.Implementations.Strategies
{
	public class SimpleCsvReadingStrategy : ICsvReadingStrategy
	{
		public List<PersonModel> Read(string path)
		{
			var lines = File.ReadAllLines(path);

			return lines
				.Select(row => row.Split(','))
				.Select(PersonMapper.ToPersonModel)
				.ToList();
		}
	}
}