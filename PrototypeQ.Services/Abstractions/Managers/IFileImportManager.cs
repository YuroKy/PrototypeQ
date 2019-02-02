using System.Collections.Generic;
using PrototypeQ.DataModel.Models;

namespace PrototypeQ.Services.Abstractions.Managers
{
	public interface IFileImportManager
	{
		List<PersonModel> Import(string path);
	}
}