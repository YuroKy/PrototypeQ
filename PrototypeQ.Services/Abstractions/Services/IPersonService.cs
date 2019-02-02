using System.Collections.Generic;
using PrototypeQ.Data.Models;

namespace PrototypeQ.Services.Abstractions.Services
{
	public interface IPersonService
	{
		List<PersonModel> GetAll();
	}
}
