using System.Collections.Generic;
using PrototypeQ.DataModel.Models;

namespace PrototypeQ.Services.Abstractions.Strategies
{
	public interface ICsvReadingStrategy
	{
		List<PersonModel> Read(string path);
	}
}
