using System.Collections.Generic;
using System.Linq;
using PrototypeQ.DataAccess.Contexts;
using PrototypeQ.DataModel.Models;
using PrototypeQ.Services.Mappers;
using PrototypeQ.Services.Services.Abstractions;

namespace PrototypeQ.Services.Services.Implementations
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