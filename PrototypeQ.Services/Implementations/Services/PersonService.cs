using System.Collections.Generic;
using System.Linq;
using PrototypeQ.DataAccess.Contexts;
using PrototypeQ.DataModel.Models;
using PrototypeQ.Services.Abstractions.Services;
using PrototypeQ.Services.Mappers;

namespace PrototypeQ.Services.Implementations.Services
{
	public class PersonService : IPersonService
	{
		private readonly ApplicationContext _dbContext;

		public PersonService(ApplicationContext dbContext)
		{
			_dbContext = dbContext;
		}

		public List<PersonModel> GetAll()
		{
			return _dbContext.People
				.Select(PersonMapper.ToPersonModel)
				.ToList();
		}
	}
}