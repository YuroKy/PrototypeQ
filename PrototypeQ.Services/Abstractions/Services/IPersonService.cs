using System.Collections.Generic;
using PrototypeQ.Data.Models;

namespace PrototypeQ.Services.Abstractions.Services
{
	public interface IPersonService
	{
		List<PersonWithIdModel> GetAll();
		List<PersonWithIdModel> GetByFilters(List<FilterModel> filters);
		void Create(PersonModel model);
		void Delete(int id);
	}
}
