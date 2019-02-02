using System.Collections.Generic;
using PrototypeQ.DataModel.Models;

namespace PrototypeQ.Services.Abstractions.Services
{
	public interface IPersonService
	{
		List<PersonModel> GetAll();
	}
}
