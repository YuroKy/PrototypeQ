using System.Collections.Generic;
using System.IO;
using PrototypeQ.DataModel.Models;
using PrototypeQ.Services.Abstractions.Strategies;
using PrototypeQ.Services.Implementations.Mappers;

namespace PrototypeQ.Services.Implementations.Strategies
{
	class LinearCsvReadingStrategy : ICsvReadingStrategy
	{
		public List<PersonModel> Read(string path)
		{
			using (var reader = new StreamReader(path))
			{
				var people = new List<PersonModel>();

				while (!reader.EndOfStream)
				{
					var columns = reader.ReadLine()?.Split(',');
					people.Add(PersonMapper.ToPersonModel(columns));
				}

				return people;
			}
		}
	}
}