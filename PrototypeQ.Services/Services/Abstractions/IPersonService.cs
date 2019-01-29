using System.Collections.Generic;
using PrototypeQ.DataModel.Models;

namespace PrototypeQ.Services.Services.Abstractions
{
	public interface IPersonService
	{
		List<PersonModel> GetAll();
	}
}
