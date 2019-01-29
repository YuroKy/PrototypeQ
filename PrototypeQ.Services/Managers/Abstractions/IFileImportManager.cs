using System.Collections.Generic;
using PrototypeQ.DataModel.Models;

namespace PrototypeQ.Services.Managers.Abstractions
{
	public interface IFileImportManager
	{
		List<PersonModel> Import(string path);
	}
}