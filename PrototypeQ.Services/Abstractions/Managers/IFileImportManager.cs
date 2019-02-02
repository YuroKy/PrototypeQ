using System.Collections.Generic;
using PrototypeQ.Data.Models;

namespace PrototypeQ.Services.Abstractions.Managers
{
	public interface IFileImportManager
	{
		List<PersonModel> Import(string path);
	}
}